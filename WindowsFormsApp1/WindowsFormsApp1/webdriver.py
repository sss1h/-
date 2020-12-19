import sys

from selenium.webdriver.common.keys import Keys
from selenium import webdriver
from time import sleep
from apscheduler.schedulers.blocking import BlockingScheduler
from datetime import datetime







def daka(username, password):


    driver = webdriver.Chrome(r"C:\Users\No.6\Desktop\WindowsFormsApp1\WindowsFormsApp1\chromedriver.exe")
    driver.get('https://ehall.jlu.edu.cn')
    i = driver.find_element_by_id('username')
    i.send_keys(username)
    passwd = driver.find_element_by_id('password')
    passwd.send_keys(password)
    passwd.send_keys(Keys.RETURN)
    sub = driver.find_element_by_id('login-submit')
    sub.click()
    sleep(1)
    tab = driver.find_element_by_link_text('本科生每日健康打卡')
    tab.click()
    handles = driver.window_handles
    cur = handles[-1]
    driver.switch_to.window(cur)
    print('switch succesful ')
    sleep(2)
    but = driver.find_element_by_id('V1_CTRL28').click()

    with open('check.html', 'wb') as f:
        src = driver.page_source
        f.write(src.encode('utf-8'))
    sleep(1)
    s = driver.find_elements_by_class_name('command_button_content')
    for t in s:
        if t.text == '提交':
            t.click()
            break
    sleep(1)
    driver.find_elements_by_tag_name('button')[-2].click()
    sleep(1)
    driver.quit()
    print('page parse successful ')
    exit()

# daka(username, password)
# daka(sys.argv[1], sys.argv[2])
# BlockingScheduler
scheduler = BlockingScheduler()
# scheduler.add_job(daka, 'cron', day_of_week = '0-6', hour = 18, minute = 14, args=['liuhao2118', 'Liuhao043758'])

scheduler.add_job(daka, 'cron', day_of_week = '0-6', hour = int(sys.argv[3]), minute = int(sys.argv[4]), args=[sys.argv[1], sys.argv[2]])
scheduler.start()