#############################################################################################
# Final CSC 217-040 Project
# Due Monday 05-07-2018
# Tessa Taylor*, Laura Techentin, Jacob Travers, Justine Forrest, Michael Nguyen, Shae Cloud
# Last edit/maintenance: 05-07-2018
# Classes: Booking
#############################################################################################

# Imports
import sys, datetime, random
import Main
from PyQt5 import QtWidgets, QtCore, QtGui
from PyQt5.QtWidgets import *
from PyQt5.QtCore import *
from PyQt5.QtGui import *
from PyQt5.QtMultimedia import QMediaPlayer, QMediaContent
import FlightSearchResults


# Booking class inherits from QMainWindow and creates a booking window that can
# return user selected information

class Booking(QMainWindow):

    # Constants
    AIRPORT_CODES = ["DEN", "LAX", "SEA"]
    #   Fonts
    FONT_LARGE = QFont("Arial", 25, QFont.Bold)
    FONT_MEDIUM = QFont("Arial", 15, QFont.Bold)
    FONT_SMALL = QFont("Arial", 10)
    #   Column and Row definitions for window layout
    COLUMN1 = 75
    COLUMN2 = 300
    COLUMN3 = 525
    COLUMN4 = 750
    ROW1 = 180
    ROW2 = 210
    ROW3 = 250
    ROW4 = 280
    ROW5 = 400
    ROW6 = 430
    ROW7 = 555

    # Class constructor
    def __init__(self, sqlConn):

        # Save sqlConnection for later
        self.sqlConnection = sqlConn

        # Call to superclass constructor
        QMainWindow.__init__(self)

        # Create the window and configure it
        self.setFixedSize(1050, 635)
        self.setGeometry(
            QStyle.alignedRect(Qt.LeftToRight,Qt.AlignCenter,QSize(1060, 725),QApplication.desktop().availableGeometry())
        )
        self.setWindowTitle("Welcome to Blue Sky Airlines")
        self.setWindowIcon(QIcon('media/favicon.ico'))

        # Get date limits for date pickers
        now = datetime.datetime.now()
        today = QDate(now.year, now.month, now.day)
        tomorrow = today.addDays(1)
        future = today.addMonths(12)
        
        # Book Flight label
        self.lblBookFlight = QLabel("Book Flight", self)
        self.lblBookFlight.setFont(self.FONT_LARGE)
        self.lblBookFlight.adjustSize()
        self.lblBookFlight.move(self.COLUMN1, 30)

        # Cities and Dates label
        self.lblCitiesAndDates = QLabel("Cities and Dates", self)
        self.lblCitiesAndDates.setFont(self.FONT_MEDIUM)
        self.lblCitiesAndDates.adjustSize()
        self.lblCitiesAndDates.move(self.COLUMN1, 100)

        # One-Way and Round Trip radio buttons
        #   One-way
        self.rdbOneWay = QRadioButton("One way", self)
        self.rdbOneWay.adjustSize()
        self.rdbOneWay.move(self.COLUMN1, 145)
        self.rdbOneWay.toggled.connect(self.handleRdbOneWay)
        #   Round trip
        self.rdbRoundTrip = QRadioButton("Round trip", self)
        self.rdbRoundTrip.adjustSize()
        self.rdbRoundTrip.move(175, 145)
        self.rdbRoundTrip.toggled.connect(self.handleRdbRoundTrip)

        # From label
        self.lblFrom = QLabel("From:", self)
        self.lblFrom.setFont(self.FONT_SMALL)
        self.lblFrom.adjustSize()
        self.lblFrom.move(self.COLUMN1, self.ROW1)

        # From drop-down menu
        self.cmbFrom = QComboBox(self)
        for code in self.AIRPORT_CODES:
            self.cmbFrom.addItem(code)
        self.cmbFrom.move(self.COLUMN1, self.ROW2)
        self.cmbFrom.currentIndexChanged.connect(self.airportCodeState)

        # To label
        self.lblTo = QLabel("To:", self)
        self.lblTo.setFont(self.FONT_SMALL)
        self.lblTo.adjustSize()
        self.lblTo.move(self.COLUMN2, self.ROW1)

        # To drop-down menu
        self.cmbTo = QComboBox(self)
        self.airportCodeState()
        self.cmbTo.move(self.COLUMN2, self.ROW2)

        # Depart Date label
        self.lblDepartDate = QLabel("Depart Date:", self)
        self.lblDepartDate.setFont(self.FONT_SMALL)
        self.lblDepartDate.adjustSize()
        self.lblDepartDate.move(self.COLUMN1, self.ROW3)

        # Depart Date datetime picker
        self.dteDepart = QDateEdit(self)
        self.dteDepart.setMinimumDate(today)
        self.dteDepart.setMaximumDate(future)
        self.dteDepart.move(self.COLUMN1, self.ROW4)

        # Depart Time of Day label
        self.lblDepartTimeOfDay = QLabel("Time of Day:", self)
        self.lblDepartTimeOfDay.setFont(self.FONT_SMALL)
        self.lblDepartTimeOfDay.adjustSize()
        self.lblDepartTimeOfDay.move(self.COLUMN2, self.ROW3)

        # Depart Time of Day drop-down menu
        self.cmbDepartTimeOfDay = QComboBox(self)
        self.cmbDepartTimeOfDay.addItem("Any Time")
        self.cmbDepartTimeOfDay.addItem("Morning")
        self.cmbDepartTimeOfDay.addItem("Afternoon")
        self.cmbDepartTimeOfDay.addItem("Evening")
        self.cmbDepartTimeOfDay.move(self.COLUMN2, self.ROW4)

        # Return Date label
        self.lblReturnDate = QLabel("Return Date:", self)
        self.lblReturnDate.setFont(self.FONT_SMALL)
        self.lblReturnDate.adjustSize()
        self.lblReturnDate.move(self.COLUMN3, self.ROW3)

        # Return Date datetime picker
        self.dteReturn = QDateEdit(self)
        self.dteReturn.setMinimumDate(tomorrow)
        self.dteReturn.setMaximumDate(future)
        self.dteReturn.move(self.COLUMN3, self.ROW4)

        # Return Time of Day label
        self.lblReturnTimeOfDay = QLabel("Time of Day:", self)
        self.lblReturnTimeOfDay.setFont(self.FONT_SMALL)
        self.lblReturnTimeOfDay.adjustSize()
        self.lblReturnTimeOfDay.move(self.COLUMN4, self.ROW3)

        # Return Time of Day drop-down menu
        self.cmbReturnTimeOfDay = QComboBox(self)
        self.cmbReturnTimeOfDay.addItem("Any Time")
        self.cmbReturnTimeOfDay.addItem("Morning")
        self.cmbReturnTimeOfDay.addItem("Afternoon")
        self.cmbReturnTimeOfDay.addItem("Evening")
        self.cmbReturnTimeOfDay.move(self.COLUMN4, self.ROW4)

        # Passengers label
        self.lblPassengers = QLabel("Passengers", self)
        self.lblPassengers.setFont(self.FONT_MEDIUM)
        self.lblPassengers.adjustSize()
        self.lblPassengers.move(self.COLUMN1, 350)

        # Adult Passengers label
        self.lblAdultPassengers = QLabel("Adult Passengers (18+):", self)
        self.lblAdultPassengers.setFont(self.FONT_SMALL)
        self.lblAdultPassengers.adjustSize()
        self.lblAdultPassengers.move(self.COLUMN1, self.ROW5)
        
        # Adult Passengers drop-down menu
        self.cmbAdultPassengers = QComboBox(self)
        for i in range(0, 11):
            self.cmbAdultPassengers.addItem(str(i))
        self.cmbAdultPassengers.setCurrentIndex(1)
        self.cmbAdultPassengers.move(self.COLUMN1, self.ROW6)
        
        # Child Passengers label
        self.lblChildPassengers = QLabel("Child Passengers (<18):", self)
        self.lblChildPassengers.setFont(self.FONT_SMALL)
        self.lblChildPassengers.adjustSize()
        self.lblChildPassengers.move(self.COLUMN2, self.ROW5)

        # Child Passengers drop-down menu
        self.cmbChildPassengers = QComboBox(self)
        for i in range(0, 11):
            self.cmbChildPassengers.addItem(str(i))
        self.cmbChildPassengers.move(self.COLUMN2, self.ROW6)

        # Add the loading gif animation
        self.movLoadingAnimation = QMovie('media/loading.gif')
        self.lblGifDisplay = QLabel(self)
        self.lblGifDisplay.setMovie(self.movLoadingAnimation)
        self.lblGifDisplay.resize(134, 75)
        self.lblGifDisplay.move(self.COLUMN4 + -130, self.ROW6 - 25)
        self.movLoadingAnimation.finished.connect(self.handleLoadingAnimationFinished)

        # Add the loading sound
        self.medLoadingSound = QMediaPlayer()
        self.medLoadingSound.setMedia(QMediaContent(QUrl('media/loading.wav')))

        # Search button
        self.btnSearch = QPushButton("Search", self)
        self.btnSearch.setFont(self.FONT_MEDIUM)
        self.btnSearch.resize(200, 75)
        self.btnSearch.move(self.COLUMN4 + 25, self.ROW6 - 25)
        self.btnSearch.clicked.connect(self.handleBtnSearch)
        
        # Add the "Quit" button
        self.btnQuit = QPushButton("Quit", self)
        self.btnQuit.setFont(self.FONT_MEDIUM)
        self.btnQuit.resize(200, 60)
        self.btnQuit.move(self.COLUMN4 + 25, self.ROW6 + 70)
        self.btnQuit.clicked.connect(self.handleBtnQuit)

        # Disable all the search option controls until a flight type is selected
        self.enableSearchControls(False, False)

    # GUI Paint event handler
    def paintEvent(self, event):
        # Setup drawing for the window and draw on it
        painter = QPainter()
        painter.begin(self)
        self.drawLine(painter)
        painter.end()

    # Draw horizontal GUI divider lines
    def drawLine(self, painter):
        # Setup the pen and draw the lines
        pen = QPen(Qt.gray, 1, Qt.SolidLine)
        painter.setPen(pen)
        painter.drawLine(self.COLUMN1, 90, self.COLUMN4 + 225, 90)
        painter.drawLine(self.COLUMN1, self.ROW4 + 60, self.COLUMN4 + 225, self.ROW4 + 60)

    # Prevent the user from selecting same airport for departure and arrival
    def airportCodeState(self):
        # Check which city is selected in the "From City" drop down
        if str(self.cmbFrom.currentText()) == "DEN":
            # Remove that city from the "To City" drop down
            self.cmbTo.clear()
            self.cmbTo.addItem("LAX", self)
            self.cmbTo.addItem("SEA", self)
        if str(self.cmbFrom.currentText()) == "LAX":
            # Remove that city from the "To City" drop down
            self.cmbTo.clear()
            self.cmbTo.addItem("DEN", self)
            self.cmbTo.addItem("SEA", self)
        if str(self.cmbFrom.currentText()) == "SEA":
            # Remove that city from the "To City" drop down
            self.cmbTo.clear()
            self.cmbTo.addItem("DEN", self)
            self.cmbTo.addItem("LAX", self)

    # Getters to return the user entered data
    def isOneWay(self):   # One-way flight
        if self.rdbOneWay.isChecked():
            return True
        elif self.rdbRoundTrip.isChecked():
            return False
        else:
            return None
    def getDepartDate(self):   # Flight depart date
        return self.dteDepart.date().toPyDate()
    def getReturnDate(self):   # Flight return date
        return self.dteReturn.date().toPyDate()
    def getDepartCode(self):   # Flight departure airport code
        if self.cmbFrom.isEnabled():
            return self.cmbFrom.currentText()
        else:
            return None
    def getToCode(self):   # Flight destination airport code
        return self.cmbTo.currentText()
    def getDepartTime(self):   # Flight departure time
        return self.cmbDepartTimeOfDay.currentText()
    def getReturnTime(self):   # Flight arrival time
        return self.cmbReturnTimeOfDay.currentText()
    def getAdultPassengers(self):   # Number of adult passengers on flight
        return self.cmbAdultPassengers.currentText()
    def getChildPassengers(self):   # Number of child passengers on flight
        return self.cmbChildPassengers.currentText()
    def getTotalPassengers(self):   # Total number of passengers on flight
        return int(self.cmbAdultPassengers.currentText()) + int(self.cmbChildPassengers.currentText())
    def getSearchBy(self):  # Selected flight sorting
        return self.cmbSearchBy.currentText()
    def getClass(self):  # Selected seat class filtering
        return self.cmbClass.currentText()

    # One-way radio button handler
    def handleRdbOneWay(self, checked):
        if (checked == True):
            self.enableSearchControls(True, False)
        elif (self.rdbRoundTrip.isChecked() == True):
            self.enableSearchControls(True, True)
        else:
            self.enableSearchControls(False, False)

    # Round trip radio button handler
    def handleRdbRoundTrip(self, checked):
        try:
            if (checked == True):
                self.enableSearchControls(True, True)
            elif (self.rdbOneWay.isChecked() == True):
                self.enableSearchControls(True, False)
            else:
                self.enableSearchControls(False, False)
        except Exception as e:
            print(str(e))
        

    # Enable or disable search controls
    def enableSearchControls(self, enable, roundTrip):
        self.lblFrom.setEnabled(enable)
        self.cmbFrom.setEnabled(enable)
        self.lblTo.setEnabled(enable)
        self.cmbTo.setEnabled(enable)
        self.lblDepartDate.setEnabled(enable)
        self.dteDepart.setEnabled(enable)
        self.lblDepartTimeOfDay.setEnabled(enable)
        self.cmbDepartTimeOfDay.setEnabled(enable)
        self.lblReturnDate.setEnabled((enable == True) and (roundTrip == True))
        self.dteReturn.setEnabled((enable == True) and (roundTrip == True))
        self.lblReturnTimeOfDay.setEnabled((enable == True) and (roundTrip == True))
        self.cmbReturnTimeOfDay.setEnabled((enable == True) and (roundTrip == True))
        self.lblPassengers.setEnabled(enable)
        self.lblAdultPassengers.setEnabled(enable)
        self.cmbAdultPassengers.setEnabled(enable)
        self.lblChildPassengers.setEnabled(enable)
        self.cmbChildPassengers.setEnabled(enable)
        self.btnSearch.setEnabled(enable)
        

    # Search button handler
    def handleBtnSearch(self):
        # Check if there are any passengers
        if self.getTotalPassengers() < 1:
            # Alert the user about the error and exit function
            msgBox = QMessageBox()
            msgBox.setWindowTitle("BlueSky Airlines")
            msgBox.setWindowIcon(QIcon('media/favicon.ico'))
            msgBox.setIcon(QMessageBox.Critical)
            msgBox.setText("You must select at least one passenger")
            msgBox.exec()
            return

        # Create a list to store flight depart and return dates
        if self.rdbOneWay.isChecked():
            self.flightDates = [self.getDepartDate(), None]
        else:
            self.flightDates = [self.getDepartDate(), self.getReturnDate()]

        #Display the loading animation
        self.btnSearch.setText("Searching...")
        self.btnSearch.setEnabled(False)
        self.medLoadingSound.play()
        self.movLoadingAnimation.start()


    # Loading animation finish playback handler
    def handleLoadingAnimationFinished(self):
        # Switch to the "Flight Search Results" window
        try:
            self.resultsWin = FlightSearchResults.FlightSearchResults(self.sqlConnection, self.getTotalPassengers(), self.isOneWay(),
                                                                      self.getDepartCode(), self.getToCode(), self.cmbDepartTimeOfDay.currentText(),
                                                                      self.cmbReturnTimeOfDay.currentText(), self.flightDates)
            self.resultsWin.show()
            self.close()
        except Exception as e:
            print(str(e))
        

    # Quit button handler
    def handleBtnQuit(self):
        # Close the application
        self.close()
