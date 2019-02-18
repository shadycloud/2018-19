#############################################################################################
# Final CSC 217-040 Project
# Due Monday 05-07-2018
# Tessa Taylor*, Laura Techentin, Jacob Travers, Justine Forrest, Michael Nguyen, Shae Cloud
# Last edit/maintenance: 05-07-2018
# Classes: Passenger
#############################################################################################

# Imports
import sys, datetime
from PyQt5 import QtGui, QtCore, QtWidgets
from PyQt5.QtCore import *
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *
import Payment

# Passenger class inherits from QMainWindow and creates a window for customers to enter
# passenger information

class Passenger(QMainWindow):

    # Constants
    #   Fonts
    FONT_LARGE = QFont("Arial", 16, QFont.Bold)
    FONT_SMALL = QFont("Arial", 12)

    # Class constructor
    def __init__(self, sqlConn, passengers, passengerNum, account, flightID, flightDates):

        # Save sqlConnection for later
        self.sqlConnection = sqlConn

        # Call to superclass constructor
        QMainWindow.__init__(self)

        # Create the window and configure it
        self.passengersLeft = passengers
        self.passengerNum = passengerNum
        self.account = account
        self.flightID = flightID
        self.flightDates = flightDates
        self.title = "Passenger Information"
        self.setWindowTitle(self.title)
        self.setWindowIcon(QIcon('media/favicon.ico'))
        self.setFixedSize(850, 500)

        # If the user has an account and is the primary passenger, retrieve the user
        # data from the database and use it to populate the form
        try:
            if self.account != 0 and self.passengerNum == 1:
                sql = '''SELECT * FROM BlueSky.Ticket WHERE passengerNum = 1 AND paymentID =
                         (SELECT paymentID from BlueSky.Login WHERE loginID = %s)'''
                self.sqlConnection.cursor.execute(sql, self.account)
                self.passengerData = self.sqlConnection.cursor.fetchall()
        except Exception as e:
            print(str(e))

        # Title label
        self.lblTitle = QLabel("Passenger " + str(self.passengerNum), self)
        self.lblTitle.setFont(self.FONT_LARGE)
        self.lblTitle.adjustSize()
        self.lblTitle.move(100, 50)

        # First Name text box
        self.txtFirstName = QLineEdit(self)
        if self.account != 0 and self.passengerNum == 1:
            self.txtFirstName.setText(self.passengerData[0][3])
        else:
            self.txtFirstName.setPlaceholderText("First Name")
        self.txtFirstName.setGeometry(100, 100, 270, 31)

        # Middle Name text box
        self.txtMiddleName = QLineEdit(self)
        if self.account != 0 and self.passengerNum == 1 and self.passengerData[0][4] != None:
            self.txtMiddleName.setText(self.passengerData[0][4])
        else:
            self.txtMiddleName.setPlaceholderText("Middle name/initial (if Shown on ID)")
        self.txtMiddleName.setGeometry(400, 100, 270, 31)

        # Last Name text box
        self.txtLastName = QLineEdit(self)
        if self.account != 0 and self.passengerNum == 1:
            self.txtLastName.setText(self.passengerData[0][5])
        else:
            self.txtLastName.setPlaceholderText("Last name")
        self.txtLastName.setGeometry(100, 150, 270, 31)

        # Date of Birth label
        self.lblBirthDate = QLabel("Date of Birth:", self)
        self.lblBirthDate.setFont(self.FONT_SMALL)
        self.lblBirthDate.adjustSize()
        self.lblBirthDate.move(100, 200)
        
        # Add the birth date widget
        self.dteBirthDate = QDateEdit(self)
        self.dteBirthDate.setMaximumDateTime(datetime.datetime.now())
        if self.account != 0 and self.passengerNum == 1:
            date = self.passengerData[0][7]
            year = date.year
            month = date.month
            day = date.day
            bday = QDate(year, month, day)
            self.dteBirthDate.setDate(bday)
        self.dteBirthDate.move(100, 240)
        
        # Gender label
        self.lblGender = QLabel("Gender:", self)
        self.lblGender.setFont(self.FONT_SMALL)
        self.lblGender.adjustSize()
        self.lblGender.move(400, 200)

        # Gender radio buttons
        #   Male
        self.rdbMale = QRadioButton("Male", self)
        self.rdbMale.adjustSize()
        self.rdbMale.move(400, 230)
        #   Female
        self.rdbFemale = QRadioButton("Female", self)
        self.rdbFemale.adjustSize()
        self.rdbFemale.move(475, 230)
        #    Button group
        self.grpGenderButtons = QButtonGroup()
        self.grpGenderButtons.addButton(self.rdbMale)
        self.grpGenderButtons.addButton(self.rdbFemale)
        if self.account != 0 and self.passengerNum == 1:
            if self.passengerData[0][6] == 'F':
                self.rdbFemale.setChecked(True)
            else:
                self.rdbMale.setChecked(True)

        # Phone Number text box
        self.txtPhoneNumber = QLineEdit(self)
        if self.account != 0 and self.passengerNum == 1:
            self.txtPhoneNumber.setText(self.passengerData[0][8])
        else:
            self.txtPhoneNumber.setPlaceholderText("Enter phone number")
        self.txtPhoneNumber.setGeometry(100, 300, 270, 31)

        # Carry-On Bag label
        self.lblCarryOn = QLabel("Carry-On Bag?", self)
        self.lblCarryOn.setFont(self.FONT_SMALL)
        self.lblCarryOn.adjustSize()
        self.lblCarryOn.move(400, 300)

        # Carry-On Bag radio buttons
        #   Yes
        self.rdbYesCarryOn = QRadioButton("Yes", self)
        self.rdbYesCarryOn.adjustSize()
        self.rdbYesCarryOn.move(550, 300)
        #   No
        self.rdbNoCarryOn = QRadioButton("No", self)
        self.rdbNoCarryOn.adjustSize()
        self.rdbNoCarryOn.move(600, 300)
        #   Button group
        self.carryOnButtons = QButtonGroup()
        self.carryOnButtons.addButton(self.rdbYesCarryOn)
        self.carryOnButtons.addButton(self.rdbNoCarryOn)
        if self.account != 0 and self.passengerNum == 1:
            if self.passengerData[0][10] == 1:
                self.rdbYesCarryOn.setChecked(True)
            else:
                self.rdbYesCarryOn.setChecked(False)
        
        # Checked Bags Label
        self.lblCheckedBags = QLabel("Checked Bags:", self)
        self.lblCheckedBags.setFont(self.FONT_SMALL)
        self.lblCheckedBags.adjustSize()
        self.lblCheckedBags.move(400, 350)
        
        # Checked Bags drop down menu
        self.cmbCheckedBags = QComboBox(self)
        for i in range(0, 6):
            self.cmbCheckedBags.addItem(str(i))
        if self.account != 0 and self.passengerNum == 1:
            self.cmbCheckedBags.setCurrentIndex(self.passengerData[0][9])
        else:
            self.cmbCheckedBags.setCurrentIndex(0)
        self.cmbCheckedBags.move(550, 350)

        # Create a "Quit" button
        self.btnQuit = QPushButton('Quit', self)
        self.btnQuit.setFont(self.FONT_LARGE)
        self.btnQuit.resize(150, 40)
        self.btnQuit.move(220, 430)
        self.btnQuit.clicked.connect(self.handleBtnQuit)

        # Create a "Clear" button
        self.btnClear = QPushButton('Clear', self)
        self.btnClear.setFont(self.FONT_LARGE)
        self.btnClear.resize(150, 40)
        self.btnClear.move(370, 430)
        self.btnClear.clicked.connect(self.handleBtnClear)

        # Create a "Continue" button
        self.btnContinue = QPushButton('Continue', self)
        self.btnContinue.setFont(self.FONT_LARGE)
        self.btnContinue.resize(150,40)
        self.btnContinue.move(520, 430)
        self.btnContinue.clicked.connect(self.handleBtnContinue)
        

    # GUI Paint event handler
    def paintEvent(self, e):
        # Setup drawing for the window and draw on it
        painter = QPainter()
        painter.begin(self)
        self.drawLines(painter)
        painter.end()
        
    # Draw horizontal GUI divider lines
    def drawLines(self, painter):
        # Setup the pen and draw the lines
        pen = QPen(Qt.black, 1, Qt.SolidLine)
        painter.setPen(pen)
        painter.drawLine(100, 80, 700, 80)
        painter.drawLine(100, 400, 700, 400)

    # Getters to return the user entered data
    def getFirstName(self):   # Passenger's First name
        return self.txtFirstName.text().strip()
    def getMiddleName(self):   # Passenger's Middle name (if exists)
        if (len(self.txtMiddleName.text()) > 0):
            return self.txtMiddleName.text().strip()
        else:
            return None
    def getLastName(self):   # Passenger's Last name
        return self.txtLastName.text().strip()
    def getBirthDate(self):   # Passenger's birth date
        return self.dteBirthDate.date().toPyDate()
    def getCheckedBags(self):   # Passenger's number of checked bags
        return self.cmbCheckedBags.currentText()
    def getGender(self):   # Passenger's gender
        if self.rdbMale.isChecked():
            return "M"
        elif self.rdbFemale.isChecked():
            return "F"
        else:
            return None
    def getCarryOn(self):   # Carry-on bag
        if (self.rdbYesCarryOn.isChecked()):
            return True
        elif (self.rdbNoCarryOn.isChecked()):
            return False
        else:
            return None
    def getPhoneNumber(self):   # Passenger's phone number
        # Remove all non-number characters from string
        convertedPhoneNumber = ""
        for i in self.txtPhoneNumber.text():
            if (i.isdigit()):
                convertedPhoneNumber += str(i)

        return convertedPhoneNumber

    # Quit button handler
    def handleBtnQuit(self):
        # Close the application
        self.close()

    # Clear button handler
    def handleBtnClear(self):
        # Reset all the fields on the window to their default values
        self.txtFirstName.clear()
        self.txtFirstName.setPlaceholderText("First Name")
        self.txtMiddleName.clear()
        self.txtMiddleName.setPlaceholderText("Middle name/initial (if Shown on ID)")
        self.txtLastName.clear()
        self.txtLastName.setPlaceholderText("Last name")
        self.txtPhoneNumber.clear()
        self.txtPhoneNumber.setPlaceholderText("Enter phone number")

    # Contintue button handler
    def handleBtnContinue(self):
        # Validate the user input
        errorString = self.validateUserInput()
        if (errorString != ""):
            # Alert the user about the error and exit function
            msgBox = QMessageBox()
            msgBox.setWindowTitle("BlueSky Airlines")
            msgBox.setWindowIcon(QIcon('media/favicon.ico'))
            msgBox.setIcon(QMessageBox.Critical)
            msgBox.setText("The following fields were invalid:\n" + errorString)
            msgBox.exec()
            return
        
        # Create a payment row in the payment table for this transaction
        if self.passengerNum == 1:    # Only create one payment row per transaction
            try:
                paymentSQL = '''INSERT INTO BlueSky.Payment (flightID, returnFlightID, flightDate, returnFlightDate)
                                VALUES (%s, %s, %s, %s)'''
                paymentData = (self.flightID[0], self.flightID[1], self.flightDates[0], self.flightDates[1])
                self.sqlConnection.cursor.execute(paymentSQL, paymentData)
            except Exception as e:
                print(str(e))

        # Insert the passenger information into the ticket table
        try:
            ticketSQL = '''INSERT INTO BlueSky.Ticket (paymentID, passengerNum, firstName, middleName,
                           lastName, gender, birthDate, phoneNumber, checkedBags, carryOn)
                           VALUES ((SELECT MAX(paymentID) FROM BlueSky.Payment), %s, %s, %s, %s, %s, %s, %s, %s, %s)'''
            ticketData = (self.passengerNum, self.getFirstName(), self.getMiddleName(), self.getLastName(), self.getGender(),
                          self.getBirthDate(), self.getPhoneNumber(), self.getCheckedBags(), self.getCarryOn())
            self.sqlConnection.cursor.execute(ticketSQL, ticketData)
        except Exception as e:
            print(str(e))

        # Decrement passengersLeft & increment passengerNum
        self.passengersLeft = self.passengersLeft - 1
        self.passengerNum = self.passengerNum + 1

        # Check if there's more passengers to configure
        if self.passengersLeft > 0:
            # Switch to the Passenger window
            self.newPassenger = Passenger(self.sqlConnection, self.passengersLeft, self.passengerNum,
                                          self.account, self.flightID, self.flightDates)
            self.newPassenger.show()
        else:
            try:
                # Switch to the payment window
                self.paymentWindow = Payment.Payment(self.sqlConnection, self.account)
                self.paymentWindow.show()
            except Exception as e:
                print(str(e))

        # Close the current window
        self.close()

    # Validate all user-input fields
    def validateUserInput(self):
        errorString = ""
        
        # First name
        firstName = self.getFirstName()
        if ((len(firstName) < 1) or (len(firstName) > 15)):
            if (errorString != ""): errorString += ", "
            errorString += "first name"
            
        # Middle name
        middleName = self.getMiddleName()
        if (middleName != None):
            if (len(middleName) > 15):
                if (errorString != ""): errorString += ", "
                errorString += "middle name"
                
        # Last name
        lastName = self.getLastName()
        if ((len(lastName) < 1) or (len(lastName) > 20)):
            if (errorString != ""): errorString += ", "
            errorString += "last name"
            
        # Gender
        gender = self.getGender()
        if (gender == None):
            if (errorString != ""): errorString += ", "
            errorString += "gender"
            
        # Phone number
        phoneNumber = self.getPhoneNumber()
        if ((len(phoneNumber) < 1) or (len(phoneNumber) > 11)):
            if (errorString != ""): errorString += ", "
            errorString += "phone number"
            
        # Carry-on bag
        carryOn = self.getCarryOn()
        if (carryOn == None):
            if (errorString != ""): errorString += ", "
            errorString += "carry-on bag"

        # Return the string of errors
        return errorString     
