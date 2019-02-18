#############################################################################################
# Final CSC 217-040 Project
# Due Monday 05-07-2018
# Tessa Taylor*, Laura Techentin, Jacob Travers, Justine Forrest, Michael Nguyen, Shae Cloud
# Last edit/maintenance: 05-07-2018
# Classes: Login
#############################################################################################

#Imports
import sys, datetime
from PyQt5 import QtGui, QtCore, QtWidgets
from PyQt5.QtCore import *
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *
import Passenger


# Login class inherits from QMainWindow and allows the user to log in to an
# existing account or continue as a guest

class Login(QMainWindow):

    # Constants
    #   Fonts
    FONT_LARGE = QFont("Arial", 16, QFont.Bold)
    FONT_SMALL = QFont("Arial", 12, QFont.Bold)

    # Class constructor
    def __init__(self, sqlConn, passengers, flightID, flightDates):

        # Save sqlConnection for later
        self.sqlConnection = sqlConn

        # Call to superclass constructor
        QMainWindow.__init__(self)

        # Save variables for later
        self.passengersLeft = passengers
        self.flightID = flightID
        self.passengerNum = 1
        self.account = 0
        self.flightDates = flightDates

        #Create the window and configure it
        self.setWindowTitle("Log In To Account")
        self.setWindowIcon(QIcon('media/favicon.ico'))
        self.setFixedSize(475, 350)

        # Login label
        self.lblLogin = QLabel("Log in to Existing Account", self)
        self.lblLogin.setFont(self.FONT_LARGE)
        self.lblLogin.move(100, 50)
        self.lblLogin.adjustSize()
        
        # Email Address text box
        self.txtUsername = QLineEdit(self)
        self.txtUsername.setPlaceholderText("Username (email address)")
        self.txtUsername.setGeometry(100, 100, 270, 31)
        self.txtUsername.textChanged.connect(self.handleUsernamePassword)
        
        # Password text box
        self.txtPassword = QLineEdit(self)
        self.txtPassword.setEchoMode(QLineEdit.Password)
        self.txtPassword.setPlaceholderText("Password")
        self.txtPassword.setGeometry(100, 150, 270, 31)
        self.txtPassword.textChanged.connect(self.handleUsernamePassword)
        
        # Login Button
        self.btnLogin = QPushButton("Log In", self)
        self.btnLogin.setFont(self.FONT_SMALL)
        self.btnLogin.setGeometry(100, 200, 270, 31)
        self.btnLogin.setEnabled(False)
        self.btnLogin.clicked.connect(self.handleLoginButton)

        # Continue as Guest Button
        self.btnGuest = QPushButton("Continue As Guest", self)
        self.btnGuest.setFont(self.FONT_SMALL)
        self.btnGuest.setGeometry(100, 250, 270, 31)
        self.btnGuest.clicked.connect(self.handleGuestButton)

    # Getters to return the user entered data
    def getUsername(self):   # User's username
        return self.txtUsername.text()
    def getPassword(self):   # User's password
        return self.txtPassword.text()

    # Username and Password textChanged handlers
    def handleUsernamePassword(self, text):
        if ((len(self.txtUsername.text()) > 0) and (len(self.txtPassword.text()) > 0)):
            # Enable login button
            self.btnLogin.setEnabled(True)
        else:
            self.btnLogin.setEnabled(False)

    # Login button handler
    def handleLoginButton(self):
        try:
            # Attempt to find the user account in the database
            sql = '''SELECT loginID from BlueSky.Login WHERE emailAddress = %s AND password = %s'''
            data = (self.getUsername(), self.getPassword())
            count = self.sqlConnection.cursor.execute(sql, data)
            if count == 0:      # Notify the user if the account does not exist
                msgBox = QMessageBox()
                msgBox.setWindowTitle("BlueSky Airlines")
                msgBox.setWindowIcon(QIcon('media/favicon.ico'))
                msgBox.setIcon(QMessageBox.Critical)
                msgBox.setText("Invalid username and/or password")
                msgBox.exec()
            else:       # Store the user's account number to populate the data in the forms
                loginID = self.sqlConnection.cursor.fetchone()
                self.account = loginID[0]
                
                # Switch to the Passenger window
                self.passengerWin = Passenger.Passenger(self.sqlConnection, self.passengersLeft, self.passengerNum,
                                                self.account, self.flightID, self.flightDates)
                self.passengerWin.show()
                self.close()
                
        except Exception as e:
            print(str(e))

    # Login as Guest button handler
    def handleGuestButton(self):
        # Switch to the Passenger window
        self.passengerWin = Passenger.Passenger(self.sqlConnection, self.passengersLeft, self.passengerNum,
                                                self.account, self.flightID, self.flightDates)
        self.passengerWin.show()
        self.close()
