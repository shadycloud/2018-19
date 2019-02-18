#############################################################################################
# Final CSC 217-040 Project
# Due Monday 05-07-2018
# Tessa Taylor*, Laura Techentin, Jacob Travers, Justine Forrest, Michael Nguyen, Shae Cloud
# Last edit/maintenance: 05-07-2018
# Classes: Database
#############################################################################################

# Imports
import pymysql

# The Database class creates a database connection object that is passed to other classes
# throughout the program
class Database():
    
    def connect(self):
        # Initialize the MySQL connection
        print("Connecting to database...")
        self.connection = pymysql.connect('cloppeshoppe.com', 'clopper', 'CloppeShoppe', autocommit=False)
        self.cursor = self.connection.cursor()
        print("Connected to database!")
