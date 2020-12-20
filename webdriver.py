import sys

from selenium.webdriver.common.keys import Keys
from selenium import webdriver
from time import sleep
from apscheduler.schedulers.blocking import BlockingScheduler







def daka(username, password):
    wait_time = 3
    driver = webdriver.Chrome()
    driver.get('https://ehall.jlu.edu.cn')
    i = driver.find_element_by_id('username')
    i.send_keys(username)
    passwd = driver.find_element_by_id('password')
    passwd.send_keys(password)
    passwd.send_keys(Keys.RETURN)
    sub = driver.find_element_by_id('login-submit')
    sub.click()
    sleep(1)
    try:
        driver.find_element_by_link_text('本科生每日健康打卡').click()
    except Exception as e:
        print('user name or password incorrect,plz check ! ')
        driver.close()
        return

    handles = driver.window_handles
    driver.switch_to.window(handles[-1])
    interval = 0
    while interval <= wait_time:
        try:
            sleep(interval)
            driver.find_element_by_xpath(
                '//div[label[font="正常 "]]/input[1]').click()
            s = driver.find_elements_by_class_name('command_button_content')
            for t in s:
                if t.text == '提交':
                    t.click()
                    break
            break
        except Exception:
            interval += 1
    if interval > wait_time:
        print('network connction error,plz check your network status')
        driver.quit()
        return

    interval = 0
    while interval < wait_time:
        try:
            sleep(interval)
            buts = driver.find_elements_by_tag_name('button')
            buts[-2].click()
            break
        except Exception:
            interval += 1
    if interval > wait_time:
        print('confirm button not captured ! ')
        driver.quit()
        return
    print('auto sign-in completed ! ')
    driver.quit()

    # driver = webdriver.Chrome(r"C:\Users\No.6\Desktop\WindowsFormsApp1\WindowsFormsApp1\chromedriver.exe")
    # driver.get('https://ehall.jlu.edu.cn')
    # i = driver.find_element_by_id('username')
    # i.send_keys(username)
    # passwd = driver.find_element_by_id('password')
    # passwd.send_keys(password)
    # passwd.send_keys(Keys.RETURN)
    # sub = driver.find_element_by_id('login-submit')
    # sub.click()
    # sleep(1)
    # tab = driver.find_element_by_link_text('本科生每日健康打卡')
    # tab.click()
    # handles = driver.window_handles
    # cur = handles[-1]
    # driver.switch_to.window(cur)
    # print('switch succesful ')
    # sleep(2)
    # but = driver.find_element_by_id('V1_CTRL28').click()
    #
    #
    # sleep(1)
    # interval = 0
    # wait_time = 3
    # while interval <= wait_time:
    #     try:
    #         sleep(interval)
    #         driver.find_element_by_xpath(
    #             '//div[label[font="正常 "]]/input[1]').click()
    #         s = driver.find_elements_by_class_name('command_button_content')
    #         for t in s:
    #             if t.text == '提交':
    #                 t.click()
    #                 break
    #         break
    #     except Exception:
    #         interval += 1
    # sleep(1)
    # interval = 0
    # while interval < wait_time:
    #     try:
    #         sleep(interval)
    #         buts = driver.find_elements_by_tag_name('button')
    #         buts[-2].click()
    #         break
    #     except Exception:
    #         interval += 1
    # sleep(1)
    # driver.quit()
    # print('page parse successful ')
    # exit()


# BlockingScheduler
scheduler = BlockingScheduler()
scheduler.add_job(daka, 'cron', day_of_week = '0-6', hour = int(sys.argv[3]), minute = int(sys.argv[4]), args=[sys.argv[1], sys.argv[2]])
scheduler.start()