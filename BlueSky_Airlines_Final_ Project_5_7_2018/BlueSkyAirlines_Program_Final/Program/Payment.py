#############################################################################################
# Final CSC 217-040 Project
# Due Monday 05-07-2018
# Tessa Taylor*, Laura Techentin, Jacob Travers, Justine Forrest, Michael Nguyen, Shae Cloud
# Last edit/maintenance: 05-07-2018
# Classes: Payment
#############################################################################################

# Imports
import sys, datetime
from PyQt5 import QtGui, QtCore, QtWidgets
from PyQt5.QtCore import *
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *
from PyQt5.QtMultimedia import QMediaPlayer, QMediaContent
import CreateAccount

# Payment class inherits from QMainWindow and creates a window for the
# customer to enter payment information

class Payment(QMainWindow):

    # Constants
    #   Fonts
    FONT_LARGE_BOLD = QFont("Arial", 16, QFont.Bold)
    FONT_LARGE = QFont("Arial", 16)
    FONT_MEDIUM = QFont("Arial", 13)
    FONT_SMALL = QFont("Arial", 9)

    # Class constructor
    def __init__(self, sqlConn, account):

        # Save the sqlConnection for later
        self.sqlConnection = sqlConn

        # Call to superclass constructor
        QMainWindow.__init__(self)

        # Save the variables for later
        self.account = account
        self.title = 'Payment Information'

        # If the user has an account, retrieve the user data from the database and use it
        # to populate the form
        try:
            if self.account != 0:
                sql = '''SELECT * FROM BlueSky.Payment WHERE paymentID = (SELECT paymentID
                         FROM BlueSky.Login WHERE loginID = %s)'''
                self.sqlConnection.cursor.execute(sql, self.account)
                self.paymentData = self.sqlConnection.cursor.fetchall()
        except Exception as e:
            print(str(e))
            
        # Create the window and configure it
        self.setWindowTitle(self.title)
        self.setWindowIcon(QIcon('media/favicon.ico'))
        self.setFixedSize(900, 750)

        # Payment Information label
        self.lblPaymentInformation = QLabel("Payment Information", self)
        self.lblPaymentInformation.setFont(self.FONT_LARGE_BOLD)
        self.lblPaymentInformation.adjustSize()
        self.lblPaymentInformation.move(150, 20)
        
        # Credit Cards image
        self.lblCreditCardsImage = QLabel(self)
        imgCreditCards = QPixmap()
        imgCreditCards.load('media/creditCards.jpg')
        imgCreditCards = imgCreditCards.scaledToWidth(400)
        self.lblCreditCardsImage.setPixmap(imgCreditCards)
        self.lblCreditCardsImage.setGeometry(150, 65, 400, 62)
        
        # Billing Information Label
        self.lblBillingInformation = QLabel("Billing Information", self)
        self.lblBillingInformation.setFont(self.FONT_MEDIUM)
        self.lblBillingInformation.adjustSize()
        self.lblBillingInformation.move(150, 140)
        
        # Instructions label
        self.lblInstructions = QLabel("Please enter your full name and address below as they appear on your debit/credit card billing statement.", self)
        self.lblInstructions.setFont(self.FONT_SMALL)
        self.lblInstructions.adjustSize()
        self.lblInstructions.move(150, 170)
        
        # Card Number text box
        self.txtCardNumber = QLineEdit(self)
        if self.account != 0:
            self.txtCardNumber.setText(self.paymentData[0][12])
        else:
            self.txtCardNumber.setPlaceholderText("Card number *")
        self.txtCardNumber.setGeometry(150, 200, 200, 31)

        # Card CVV text box
        self.txtCVV = QLineEdit(self)
        if self.account!= 0:
            self.txtCVV.setText(self.paymentData[0][13])
        else:
            self.txtCVV.setPlaceholderText("CVV *")
        self.txtCVV.setGeometry(370, 200, 50, 31)
        
        # Expiration Month drop down menu
        self.cmbExpirationMonth = QComboBox(self)
        self.cmbExpirationMonth.addItem("Expiration month *")
        self.cmbExpirationMonth.addItem("January")
        self.cmbExpirationMonth.addItem("February")
        self.cmbExpirationMonth.addItem("March")
        self.cmbExpirationMonth.addItem("April")
        self.cmbExpirationMonth.addItem("May")
        self.cmbExpirationMonth.addItem("June")
        self.cmbExpirationMonth.addItem("July")
        self.cmbExpirationMonth.addItem("August")
        self.cmbExpirationMonth.addItem("September")
        self.cmbExpirationMonth.addItem("October")
        self.cmbExpirationMonth.addItem("November")
        self.cmbExpirationMonth.addItem("December")
        self.cmbExpirationMonth.setGeometry(150, 250, 200, 31)
        if self.account != 0:
            self.cmbExpirationMonth.setCurrentIndex(self.paymentData[0][14])
        else:
            self.cmbExpirationMonth.setCurrentIndex(0)
        
        # Expiration Year drop down menu
        self.cmbExpirationYear = QComboBox(self)
        self.cmbExpirationYear.addItem("Year *")
        currentYear = datetime.datetime.today().year
        for y in range(currentYear, currentYear + 10):
            self.cmbExpirationYear.addItem(str(y))
        self.cmbExpirationYear.setGeometry(370, 250, 70, 31)
        if self.account != 0:
            index = self.cmbExpirationYear.findText(str(self.paymentData[0][15]))
            self.cmbExpirationYear.setCurrentIndex(index)
        else:
            self.cmbExpirationYear.setCurrentIndex(0)
        
        # Full Name text box
        self.txtFullName = QLineEdit(self)
        if self.account != 0:
            self.txtFullName.setText(self.paymentData[0][6])
        else:
            self.txtFullName.setPlaceholderText("Full name as it appears on your card *")
        self.txtFullName.setGeometry(150, 300, 550, 31)
        
        # Billing Address text boxes
        self.txtBillingAddress = QLineEdit(self)
        if self.account != 0:
            self.txtBillingAddress.setText(self.paymentData[0][7])
        else:
            self.txtBillingAddress.setPlaceholderText("Billing address *")
        self.txtBillingAddress.setGeometry(150, 350, 300, 31)
        
        # City/Town/Department text box
        self.txtCity = QLineEdit(self)
        if self.account != 0:
            self.txtCity.setText(self.paymentData[0][8])
        else:
            self.txtCity.setPlaceholderText("City/town/department *")
        self.txtCity.setGeometry(150, 400, 180, 31)
        
        # State/Province/Region/County text box
        self.txtState = QLineEdit(self)
        if self.account != 0:
            self.txtState.setText(self.paymentData[0][9])
        else:
            self.txtState.setPlaceholderText("State/province/region/county *")
        self.txtState.setGeometry(340, 400, 200, 31)
        
        # ZIP/Postal Code text box
        self.txtZipCode = QLineEdit(self)
        if self.account != 0:
            self.txtZipCode.setText(self.paymentData[0][11])
        else:
            self.txtZipCode.setPlaceholderText("ZIP/Postal code *")
        self.txtZipCode.setGeometry(550, 400, 110, 31)
        
        # Country drop down menu
        self.cmbCountry = QComboBox(self)
        self.cmbCountry.addItem("United States")
        self.cmbCountry.addItem("Canada")
        self.cmbCountry.addItem("United Kingdom")
        self.cmbCountry.addItem("France")
        self.cmbCountry.addItem("Vietnam")
        self.cmbCountry.setGeometry(150, 450, 200, 31)
        if self.account != 0:
            index = self.cmbCountry.findText(self.paymentData[0][10])
            self.cmbCountry.setCurrentIndex(index)
        else:
            self.cmbCountry.setCurrentIndex(0)

        # Total Price label
        try:    # Retrieve the price and number of tickets purchased from the database
            countSQL = '''SELECT * FROM BlueSky.Ticket WHERE paymentID = (SELECT MAX(paymentID) FROM BlueSky.Payment)'''
            count = self.sqlConnection.cursor.execute(countSQL)
            priceSQL = '''SELECT price FROM BlueSky.Flight f JOIN BlueSky.Payment p ON f.flightID = p.flightID
                          WHERE p.paymentID = (SELECT MAX(paymentID) FROM BlueSky.Payment)'''
            self.sqlConnection.cursor.execute(priceSQL)
            price = self.sqlConnection.cursor.fetchone()
            # Check to see if there is a return flight
            returnFlightSQL = '''SELECT returnFlightID FROM BlueSky.Payment WHERE paymentID = (SELECT MAX(paymentID) FROM
                                 BlueSky.Payment)'''
            self.sqlConnection.cursor.execute(returnFlightSQL)
            returnFlight = self.sqlConnection.cursor.fetchone()
            if returnFlight[0] == 0:    # Calculate the total price and display it on the form
                totalPrice = count * price[0]
            else:   # Account for return flight costs if necessary
                returnPriceSQL = '''SELECT price FROM BlueSky.Flight f JOIN BlueSky.Payment p ON f.flightID =
                                    p.returnFlightID WHERE p.paymentID = (SELECT MAX(paymentID) FROM BlueSky.Payment)'''
                self.sqlConnection.cursor.execute(returnPriceSQL)
                returnPrice = self.sqlConnection.cursor.fetchone()
                totalPrice = count * (price[0] + returnPrice[0])
            self.lblTotalPrice = QLabel("Total: $" + str(totalPrice), self)
            self.lblTotalPrice.setFont(self.FONT_LARGE)
            self.lblTotalPrice.adjustSize()
            self.lblTotalPrice.move(150, 510)
        except Exception as e:
            print(str(e))

        # Purchase button
        self.btnPurchase = QPushButton("Purchase", self)
        self.btnPurchase.setFont(self.FONT_LARGE_BOLD)
        self.btnPurchase.clicked.connect(self.handlePurchaseButton)
        self.btnPurchase.resize(175, 50)
        self.btnPurchase.move(525, 580)

        # Add the loading gif animation
        self.movLoadingAnimation = QMovie("media/loading.gif")
        self.movLoadingAnimation.finished.connect(self.handleLoadingAnimationFinished)
        self.lblGifDisplay = QLabel(self)
        self.lblGifDisplay.setMovie(self.movLoadingAnimation)
        self.lblGifDisplay.resize(134, 75)
        self.lblGifDisplay.move(710, 580)

        # Add the loading sound
        self.medPaymentSound = QMediaPlayer()
        self.medPaymentSound.setMedia(QMediaContent(QUrl('media/cash-register.wav')))

        # Purchase and Create Account Button
        if self.account == 0:
            self.btnCreateAccount = QPushButton("Purchase and Create Account", self)
            self.btnCreateAccount.setFont(self.FONT_LARGE_BOLD)
            self.btnCreateAccount.clicked.connect(self.handleAccountButton)
            self.btnCreateAccount.resize(450, 50)
            self.btnCreateAccount.move(210, 650)

        # Clear button
        self.btnClear = QPushButton("Clear", self)
        self.btnClear.setFont(self.FONT_LARGE_BOLD)
        self.btnClear.clicked.connect(self.handleClearButton)
        self.btnClear.resize(175, 50)
        self.btnClear.move(350, 580)

        # Quit button
        self.btnQuit = QPushButton("Quit", self)
        self.btnQuit.setFont(self.FONT_LARGE_BOLD)
        self.btnQuit.clicked.connect(self.handleQuitButton)
        self.btnQuit.resize(175, 50)
        self.btnQuit.move(175, 580)

    # Getters to return the user entered data
    def getCardNumber(self):   # User's credit card number
        # Remove all non-number characters from string
        convertedCardNumber = ""
        for i in self.txtCardNumber.text():
            if (i.isdigit()):
                convertedCardNumber += str(i)

        return convertedCardNumber
    def getCVV(self):
        # Remove all non-number characters from CVV
        convertedCVV = ""
        for i in self.txtCVV.text():
            if (i.isdigit()):
                convertedCVV += str(i)
                
        return convertedCVV
    def getExpirationMonth(self):   # User's credit card expiration month
        if ('*' in self.cmbExpirationMonth.currentText()):
            return None
        else:
            return self.cmbExpirationMonth.currentIndex()
    def getExpirationYear(self):   # User's credit card expiration year
        if ('*' in self.cmbExpirationYear.currentText()):
            return None
        else:
            return int(self.cmbExpirationYear.currentText())
    def getFullName(self):   # User's full name
        return self.txtFullName.text().strip()
    def getBillingAddress(self):   # User's billing address
        return self.txtBillingAddress.text().strip()
    def getCity(self):   # User's billing city
        return self.txtCity.text().strip()
    def getState(self):   # User's billing state
        return self.txtState.text().strip()
    def getZipCode(self):   # User's billing zip code
        return self.txtZipCode.text()
    def getCountry(self):   # User's billing country
        return self.cmbCountry.currentText()

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
        painter.drawLine(150, 50, 700, 50)
        painter.drawLine(150, 500, 700, 500)

    # Create Account button handler
    def handleAccountButton(self):
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

        self.sendToDatabase()   # Send the user input info to the database

        # Switch to the "Create Account" window
        self.signupWindow = CreateAccount.CreateAccount(self.sqlConnection)
        self.signupWindow.show()
        self.close()
        
    # Purchase button handler
    def handlePurchaseButton(self):
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

        self.sendToDatabase()   # Send the user input info to the database
        
        # Start the loading animation
        self.btnPurchase.setText("Purchasing...")
        self.btnPurchase.setEnabled(False)
        self.movLoadingAnimation.start()
        self.medPaymentSound.play()

    # Validate all user-input fields
    def validateUserInput(self):
        errorString = ""

        # Credit card number
        cardNumber = self.getCardNumber()
        if (len(cardNumber) != 16):
            if (errorString != ""): errorString += ", "
            errorString += "card number"

        # Credit card CVV
        cvv = self.getCVV()
        if (len(cvv) != 3):
            if (errorString != ""): errorString += ", "
            errorString += "card CVV"

        # Expiration month
        expirationMonth = self.getExpirationMonth()
        if (expirationMonth == None):
            if (errorString != ""): errorString += ", "
            errorString += "card expiration month"

        # Expiration year
        expirationYear = self.getExpirationYear()
        if (expirationYear == None):
            if (errorString != ""): errorString += ", "
            errorString += "card expiration year"

        # Full name
        fullName = self.getFullName()
        if ((len(fullName) < 1) or (len(fullName) > 50)):
            if (errorString != ""): errorString += ", "
            errorString += "full name"

        # Billing address
        billingAddress = self.getBillingAddress()
        if ((len(billingAddress) < 1) or (len(billingAddress) > 50)):
            if (errorString != ""): errorString += ", "
            errorString += "billing address"

        # City
        city = self.getCity()
        if ((len(city) < 1) or (len(city) > 25)):
            if (errorString != ""): errorString += ", "
            errorString += "billing city"

        # State
        state = self.getState()
        if ((len(state) < 1) or (len(state) > 15)):
            if (errorString != ""): errorString += ", "
            errorString += "billing state"

        # Zip code
        zipCode = self.getZipCode()
        if ((len(zipCode) < 1) or (len(zipCode) > 6)):
            if (errorString != ""): errorString += ", "
            errorString += "billing zip code"

        # Return the string of errors
        return errorString
        

    # Loading animation finish playback handler
    def handleLoadingAnimationFinished(self):
        self.close()

    # Clear button handler
    def handleClearButton(self):
        # Print the data to the terminal
        self.txtCardNumber.clear()
        self.txtCardNumber.setPlaceholderText("Card number *")
        self.txtCVV.clear()
        self.txtCVV.setPlaceholderText("CVV *")
        self.cmbExpirationMonth.setCurrentIndex(0)
        self.cmbExpirationYear.setCurrentIndex(0)
        self.txtFullName.clear()
        self.txtFullName.setPlaceholderText("Full name as it appears on your card *")
        self.txtBillingAddress.clear()
        self.txtBillingAddress.setPlaceholderText("Billing address *")
        self.txtCity.clear()
        self.txtCity.setPlaceholderText("City/town/department *")
        self.txtState.clear()
        self.txtState.setPlaceholderText("State/province/region/county *")
        self.txtZipCode.clear()
        self.txtZipCode.setPlaceholderText("ZIP/Postal code *")
        self.cmbCountry.setCurrentIndex(0)

    # Quit button handler
    def handleQuitButton(self):
        # Close the application
        self.close()

    # Send the payment information to the database
    def sendToDatabase(self):
        try:
            sql = '''UPDATE BlueSky.Payment SET purchaseDate = DEFAULT, fullNameOnCard = %s, billingAddress = %s, billingCity = %s,
                     billingState = %s, billingCountry = %s, billingZipCode = %s, billingCard = %s, billingCVV = %s,
                     billingExpMonth = %s, billingExpYear = %s WHERE paymentID = (SELECT MAX(paymentID) FROM
                     (SELECT * FROM BlueSky.Payment) AS PaymentTable)'''

            data = (self.getFullName(), self.getBillingAddress(), self.getCity(), self.getState(), self.getCountry(), self.getZipCode(),
                    self.getCardNumber(), self.getCVV(), self.getExpirationMonth(), self.getExpirationYear())

            self.sqlConnection.cursor.execute(sql, data)
            self.sqlConnection.connection.commit()     # Commit all changes made to the database
        except Exception as e:
            print(str(e))
