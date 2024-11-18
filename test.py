from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.keys import Keys
import time

driver = webdriver.Chrome()

try:
    driver.get("https://quvangkøreskole.dk")
    
    time.sleep(3)

    # Test 1 Title
    ## Arrange
    desc = "Test for correct titel, we know we have the correct website"
    arrange = "Kørekort til bil med tryghed og tillid."
    act = driver.title
    error = "Test 1 - Expected title: " + arrange + " Got: " + driver.title
    ## Act
    result = arrange == act 
    ## Assert
    assert result, error
    
    ## Success
    print("Test 1 Title - " + desc + " - succesfull")
    

    # Test 2 Redirect to "Om Mig" 
    ## Arrange
    desc = "Test for page, we know we have open about me page"
    aboutMeButton = driver.find_element(By.LINK_TEXT, "Om Mig")
    aboutMeButton.click()
    arrange = "Quvang Køreskole"
    act = driver.title
    error = "Test 2 - Expected title: " + arrange + " Got: " + driver.title
    ## Act
    result = arrange == act 
    ## Assert
    assert result, error
    
    ## Success
    print("Test 1 Title - " + desc + " - succesfull") # Remember we are not home

    # Test 3 Open modal
    
    # Test 4 Different driver license
    
    # Test 5 What happen if we do this 1000 times? 2k ? 10k ?

    print("All test pass")
    
except Exception as e:
    print(f"Test fejlet: {e}")

finally:
    driver.quit()
