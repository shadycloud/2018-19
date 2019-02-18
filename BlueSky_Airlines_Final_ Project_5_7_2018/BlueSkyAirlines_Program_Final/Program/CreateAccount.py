#############################################################################################
# Final CSC 217-040 Project
# Due Monday 05-07-2018
# Tessa Taylor*, Laura Techentin, Jacob Travers, Justine Forrest, Michael Nguyen, Shae Cloud
# Last edit/maintenance: 05-07-2018
# Classes: CreateAccount
#############################################################################################

# Imports
import sys, datetime
from PyQt5 import QtGui, QtCore, QtWidgets
from PyQt5.QtCore import *
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *


# CreateAccount class inherits from QMainWindow and allows the
# user to create and save an account

class CreateAccount(QMainWindow):

     # Constants
     #   Fonts
     FONT_LARGE = QFont("Arial", 20, QFont.Bold)
     FONT_MEDIUM = QFont("Arial", 14)
     FONT_SMALL = QFont("Arial", 12, QFont.Bold)

     # Class constructor
     def __init__(self, sqlConn):

          # Save sqlConnection for later
          self.sqlConnection = sqlConn
          
          # Call to superclass constructor   
          QMainWindow.__init__(self)

          # Create the window and configure it
          self.setWindowTitle("Create Account")
          self.setWindowIcon(QIcon('media/favicon.ico'))
          self.setFixedSize(500, 400)

          # Create Account label
          self.lblCreateAccount = QLabel("Create Account",self)
          self.lblCreateAccount.setFont(self.FONT_LARGE)
          self.lblCreateAccount.move(20, 40)
          self.lblCreateAccount.adjustSize()
            
          # Email label
          self.lblUsername = QLabel("Username (Email):", self)
          self.lblUsername.setFont(self.FONT_MEDIUM)
          self.lblUsername.move(40, 150)
          self.lblUsername.adjustSize()
            
          # Email text box
          self.txtUsername = QLineEdit(self)
          self.txtUsername.setGeometry(230, 148, 200, 30)
            
          # Password label
          self.lblPassword = QLabel("Password:", self)
          self.lblPassword.setFont(self.FONT_MEDIUM)
          self.lblPassword.move(100, 200)
          self.lblPassword.adjustSize()
            
          # Password text box
          self.txtPassword = QLineEdit(self)
          self.txtPassword.setEchoMode(QLineEdit.Password)
          self.txtPassword.setGeometry(230, 198, 200, 30)

          # Cancel button
          self.btnCancel = QPushButton("Cancel",self)
          self.btnCancel.setFont(self.FONT_SMALL)
          self.btnCancel.move(220, 298)
          self.btnCancel.clicked.connect(self.handleCancelButton)

          # Create button
          self.btnCreate = QPushButton("Create", self)
          self.btnCreate.setFont(self.FONT_SMALL)
          self.btnCreate.move(320, 298)
          self.btnCreate.clicked.connect(self.handleCreateButton)

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
          painter.drawLine(0,80, 500, 80)

     # Getter methods to return user entered info
     def getUsername(self):   # User's username
          return self.txtUsername.text()
     def getPassword(self):   # User's password
          return self.txtPassword.text()

     # Cancel button handler
     def handleCancelButton(self):
          # Cancel the account creation
          print("Account not created.")
          
          # TODO: Will advance to summary screen
          self.close()

     # Create Account button handler
     def handleCreateButton(self):
          # Creates a user account in the database
          try:
               # Checks to see if the user already has an account
               findEmailSQL = '''SELECT * FROM BlueSky.Login WHERE emailAddress = %s'''
               count = self.sqlConnection.cursor.execute(findEmailSQL, self.getUsername())
               if count == 0:      # Creates an account if one does not yet exist
                    sql = '''INSERT INTO BlueSky.Login (paymentID, emailAddress, password) VALUES
                             ((SELECT MAX(paymentID) FROM BlueSky.Payment), %s, %s)'''
                    data = (self.getUsername(), self.getPassword())
                    self.sqlConnection.cursor.execute(sql, data)
                    self.sqlConnection.connection.commit()  # Commit all changes to the database
                    # TODO: Will advance to summary screen
                    self.close()
               else:     # Notify the user if an account already exists
                    msgBox = QMessageBox()
                    msgBox.setWindowTitle("BlueSky Airlines")
                    msgBox.setWindowIcon(QIcon('media/favicon.ico'))
                    msgBox.setIcon(QMessageBox.Critical)
                    msgBox.setText("Email address already associated with account")
                    msgBox.exec()
          except Exception as e:
               print(str(e))
