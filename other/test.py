import unittest
import time
import json
import os
import shutil

data_dir = '/Users/mohammedabualrob/projects/visual/server/data/'
reports_dir = '/Users/mohammedabualrob/projects/visual/reports'
#sim_dir = '/Users/mohammedabualrob/Library/Developer/CoreSimulator/Devices/1AC8E4F3-F9A8-4458-A489-5D39D1D6C997'


#---------------------------------- Setup Module ----------------------------------------#

def setUpModule():

	printLine('Module Setup', False)
		
#--------------------------------- Tear Down Module -------------------------------------#

def tearDownModule():

	printLine('Module Teardown', False)

#------------------------------------ Base Case -----------------------------------------#

class BaseCase(unittest.TestCase):
	
	#----------------------------------- Setup ------------------------------------------#
	
	def setUp(self):

		printLine('Setup', False)
		
	#---------------------------------- Tear Down ---------------------------------------#
	
	def tearDown(self):

		printLine('Teardown', False)

#----------------------------------- Force Portrait -------------------------------------#

@unittest.skip("Skipping")
class ForcePortrait(BaseCase):

	#-------------------------------- Setup Class ---------------------------------------#
	
	@classmethod
	def setUpClass(self):

		printLine('Force Portrait Setup', False)

	#------------------------------ Tear Down Class -------------------------------------#
	
	@classmethod
	def tearDownClass(self):

		printLine('Force Portrait Teardown', False)

	#---------------------------------- Tear Down ---------------------------------------#
	
	def tearDown(self):

		printLine('Teardown', False)

    #--------------------------------------- 1 ------------------------------------------#
    
	@unittest.skip("Skipping")
	def test_001_ForcePortraitNormal(self):
    
		printLine('001 - Force Portrait Normal')
		
		# Wait for the Arabian frame in portrait
		# self.assertNotEqual(waitImage(img_dir + "arabian_portrait.png", True, 10), None)

#----------------------------------------- Main -----------------------------------------#

if __name__ == '__main__':
    import xmlrunner
    unittest.main(testRunner=xmlrunner.XMLTestRunner(output=reports_dir))
