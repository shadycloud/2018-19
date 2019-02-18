#############################################################################################
# Final CSC 217-040 Project
# Due Monday 05-07-2018
# Tessa Taylor*, Laura Techentin, Jacob Travers, Justine Forrest, Michael Nguyen, Shae Cloud
# Last edit/maintenance: 05-07-2018
# Starts the program
#############################################################################################

# Imports
import sys, datetime, pymysql
from PyQt5.QtWidgets import *
import Database, SplashScreen

sqlConnection = Database.Database()

# Main function
if __name__ == "__main__":

    # Initialize the MySQL connection
    sqlConnection.connect()
    
    # Start the application with the splash screen
    app = QApplication(sys.argv)
    splashWin = SplashScreen.SplashScreen(sqlConnection)
    splashWin.showSplash(False)   # Flag sets whether to skip splash screen
    sys.exit(app.exec_())

