#############################################################################################
# Final CSC 217-040 Project
# Due Monday 05-07-2018
# Tessa Taylor*, Laura Techentin, Jacob Travers, Justine Forrest, Michael Nguyen, Shae Cloud
# Last edit/maintenance: 05-07-2018
# Classes: FlightSearchResults, ReturnFlights
#############################################################################################

# Imports
import sys
from PyQt5 import QtWidgets, QtGui, QtCore
from PyQt5.QtWidgets import *
from PyQt5.QtGui import *
from PyQt5.QtCore import *
import Booking
import Login


# FlightSearchResults class inherits from the QMainWindow class and creates a window with flight
# search results where the user can select a flight

class FlightSearchResults(QMainWindow):

    # Constants
    
    #   Fonts
    FONT_LARGE = QFont("Arial", 25, QFont.Bold)
    FONT_MEDIUM = QFont("Arial", 15, QFont.Bold)
    FONT_SMALL = QFont("Arial", 10, QFont.Bold)
    #   Column and Row definitions for window layout
    COLUMN1 = 75
    ROW1 = 30
    ROW2 = 100

    # Class constructor
    def __init__(self, sqlConn, passengers, oneWay, fromCity, toCity, departTimeOfDay, returnTimeOfDay, flightDates):

        # Save sqlConnection for later
        self.sqlConnection = sqlConn

        # Call to superclass constructor
        QMainWindow.__init__(self)

        # Create the window and configure it
        self.setFixedSize(1050, 700)
        self.setWindowTitle("Flight Search Results")
        self.setWindowIcon(QIcon('media/favicon.ico'))
        self.passengers = passengers
        self.isOneWay = oneWay
        self.fromCity = fromCity
        self.toCity = toCity
        self.departTimeOfDay = departTimeOfDay
        self.returnTimeOfDay = returnTimeOfDay

        if (self.departTimeOfDay == 'Any Time'):
            self.departTimePeriod = (0,24)
        elif (self.departTimeOfDay == 'Morning'):
            self.departTimePeriod = (0,12)
        elif (self.departTimeOfDay == 'Afternoon'):
            self.departTimePeriod = (13,18)
        elif (self.departTimeOfDay == 'Evening'):
            self.departTimePeriod = (19,24)
        else:
            self.departTimePeriod = (0,24)

        self.flightDates = flightDates
        

        # Retrieve the flights from the database
        sql = '''SELECT flightID, flightNum, planeModel, departCity, TIME_FORMAT(departTime, '%%H:%%i'), arrivalCity, TIME_FORMAT(arrivalTime, '%%H:%%i'),
                 (CASE WHEN nonStop <> 0 THEN 'Yes' ELSE 'No' END), (CASE WHEN mealService <> 0 THEN 'Yes' ELSE 'No' END), CAST(price AS CHAR)
                 FROM BlueSky.Flight WHERE departCity = %s AND arrivalCity = %s AND HOUR(departTime) >= %s AND HOUR(departTime) <= %s'''
        data = (self.fromCity, self.toCity, self.departTimePeriod[0], self.departTimePeriod[1])
        self.sqlConnection.cursor.execute(sql, data)
        self.FLIGHTS = self.sqlConnection.cursor.fetchall()
        
        # Add the "Search Results:" label
        self.lblSearchResults = QLabel("Select Flight:", self)
        self.lblSearchResults.setFont(self.FONT_LARGE)
        self.lblSearchResults.adjustSize()
        self.lblSearchResults.move(self.COLUMN1, self.ROW1)

        # Add the flights search results table
        header = ["Select:", "Flight #:", "Plane Model:", "From:", "Depart Time:", "To:",
                  "Arrival Time:", "Non-Stop?", "Meal Service?", "Price:"]
        self.tblResults = QTableWidget(25, 10, self)
        self.tblResults.horizontalHeader().setFont(self.FONT_SMALL)
        self.tblResults.horizontalHeader().setDefaultAlignment(Qt.AlignLeft)
        self.tblResults.setHorizontalHeaderLabels(header)
        self.tblResults.setSortingEnabled(True)

        # Add the flights to the table
        for i in range(0, len(self.FLIGHTS)):
            for j in range(1, self.tblResults.columnCount()):
                self.tblResults.setItem(i, j, QTableWidgetItem(self.FLIGHTS[i][j]))

        self.tblResults.resize(900, 400)
        self.tblResults.resizeColumnsToContents()
        self.tblResults.move(self.COLUMN1, self.ROW2)

        # Add check boxes for each flight
        self.checkBoxGroup = QButtonGroup()
        self.checkBoxGroup.setExclusive(True)
        self.checkBoxDict = {}
        for i in range(0, len(self.FLIGHTS)):
            self.checkBoxDict["box{0}".format(i)] = QCheckBox()
            self.checkBoxDict["box{0}".format(i)].setCheckState(Qt.Unchecked)
            self.checkBoxGroup.addButton(self.checkBoxDict["box{0}".format(i)])
        for i in range(0, len(self.FLIGHTS)):
            cellWidget = QWidget()
            layout = QHBoxLayout(cellWidget)
            layout.addWidget(self.checkBoxDict["box{0}".format(i)])
            layout.setAlignment(Qt.AlignCenter)
            layout.setContentsMargins(0, 0, 0, 0)
            cellWidget.setLayout(layout)
            self.tblResults.setCellWidget(i, 0, cellWidget)

        # Add the "Continue" button
        self.btnContinue = QPushButton("Continue", self)
        self.btnContinue.setFont(self.FONT_MEDIUM)
        self.btnContinue.resize(200, 75)
        self.btnContinue.clicked.connect(self.handleContinueButton)
        self.btnContinue.move(800, 550)

        # Add the "Quit" button
        self.btnExit = QPushButton("Quit", self)
        self.btnExit.setFont(self.FONT_MEDIUM)
        self.btnExit.resize(200, 75)
        self.btnExit.clicked.connect(self.handleQuitButton)
        self.btnExit.move(50, 550)

        # Add the "Back" button
        self.btnBack = QPushButton("Back", self)
        self.btnBack.setFont(self.FONT_MEDIUM)
        self.btnBack.resize(200, 75)
        self.btnBack.clicked.connect(self.handleBackButton)
        self.btnBack.move(425, 550)

    # Getter to return selected flight
    def getFlight(self):
        flight = None
        # Loop through the items in the list and return the first one that's checked
        for i in range(0, len(self.checkBoxDict)):
            if self.checkBoxDict["box{0}".format(i)].isChecked():
                flight = self.FLIGHTS[i][0]
        return flight

    # Continue button handler
    def handleContinueButton(self):
        # Ensure a flight was selected
        if (self.getFlight() == None):
            # Alert the user about the error and exit function
            msgBox = QMessageBox()
            msgBox.setWindowTitle("BlueSky Airlines")
            msgBox.setWindowIcon(QIcon('media/favicon.ico'))
            msgBox.setIcon(QMessageBox.Critical)
            msgBox.setText("You must select a flight before continuing.")
            msgBox.exec()
            return
        
        if not self.isOneWay:   # Two-way flight
            try:
                # Switch to the Return Flights window
                self.returnFlights = ReturnFlights(self.sqlConnection, self.passengers, self.isOneWay, self.toCity,
                                                   self.fromCity, self.returnTimeOfDay, self.getFlight(), self.flightDates)
                self.returnFlights.show()
            except Exception as e:
                print(str(e))
        else:   # One-way flight
            flightID = [self.getFlight(), 0]    # Create a list to store the flight ID(s)
            self.loginWindow = Login.Login(self.sqlConnection, self.passengers, flightID, self.flightDates)
            self.loginWindow.show()
            
        # Close the current window
        self.close()

    # Quit button handler
    def handleQuitButton(self):
        # Exit the application
        self.close()

    # Back button handler
    def handleBackButton(self):
        # Switch to the Booking window
        self.newSearch = Booking.Booking(self.sqlConnection)
        self.newSearch.show()
        self.close()


# ReturnFlights class inherits from the FlightSearchResults class and opens a window for the
# user to choose a return flight

class ReturnFlights(FlightSearchResults):

    # Class constructor
    def __init__(self, sqlConn, passengers, oneWay, fromCity, toCity, returnTimeOfDay, flight, flightDates):

        # Call to superclass constructor
        FlightSearchResults.__init__(self, sqlConn, passengers, oneWay, fromCity, toCity, returnTimeOfDay, -1, flightDates)

        # Create the window and configure it
        self.lblSearchResults.setText("Select Return Flight:")
        self.lblSearchResults.adjustSize()
        self.flight = flight

    # Continue button handler (overridden from superclass)
    def handleContinueButton(self):
        # Ensure a flight was selected
        if (self.getFlight() == None):
            # Alert the user about the error
            msgBox = QMessageBox()
            msgBox.setWindowTitle("BlueSky Airlines")
            msgBox.setWindowIcon(QIcon('media/favicon.ico'))
            msgBox.setIcon(QMessageBox.Critical)
            msgBox.setText("You must select a flight before continuing.")
            msgBox.exec()
        else:
            flightID = [self.flight, self.getFlight()]  # Create a list to store the flight IDs
            #Switch to the Login window
            self.loginWindow = Login.Login(self.sqlConnection, self.passengers, flightID, self.flightDates)
            self.loginWindow.show()
            self.close()
