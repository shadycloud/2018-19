#############################################################################################
# Final CSC 217-040 Project
# Due Monday 05-07-2018
# Tessa Taylor*, Laura Techentin, Jacob Travers, Justine Forrest, Michael Nguyen, Shae Cloud
# Last edit/maintenance: 05-07-2018
# Classes: SplashScreen
#############################################################################################

# Imports
import sys, time
from PyQt5 import QtWidgets, QtCore, QtGui
from PyQt5.QtWidgets import *
from PyQt5.QtCore import *
from PyQt5.QtGui import *
from PyQt5.QtMultimediaWidgets import QVideoWidget
from PyQt5.QtMultimedia import QMediaPlayer, QMediaContent
import Booking


# SplashScreen class inherits from QVideoWidget and creates a window that displays the
# splash screen animation

class SplashScreen(QVideoWidget):
    def __init__(self, sqlConn):

        # Save sqlConnection for later
        self.sqlConnection = sqlConn
        
        # Call to superclass constructor
        QVideoWidget.__init__(self)
        
        #Create window and configure it
        self.setGeometry(
            QStyle.alignedRect(Qt.LeftToRight,Qt.AlignCenter,QSize(1280,720),QApplication.desktop().availableGeometry())
        )
        self.setWindowTitle("BlueSky Airlines")
        self.setWindowIcon(QIcon('media/favicon.ico'))
        self.setWindowFlags(Qt.FramelessWindowHint)
        self.setStyleSheet('background-color: white;')

        #Setup the video player
        self.videoPlayer = QMediaPlayer()
        self.videoPlayer.setMedia(QMediaContent(QUrl('media/splashAnimation.avi')))
        self.videoPlayer.setVideoOutput(self)
        self.videoPlayer.stateChanged.connect(self.handleVideoDone)

 
    def showSplash(self, skipAnimation):
        if (skipAnimation == False):
            #Open the window and start the splash animation video
            self.show()
            self.videoPlayer.play()
        else:
            self.handleVideoDone(0)
        

    def handleVideoDone(self, state):
        if (state == 0):   #Video is done playing
            #Switch to the Booking window
            self.bookWin = Booking.Booking(self.sqlConnection)
            self.bookWin.show()
            self.close()
        
