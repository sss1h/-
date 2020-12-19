from selenium.webdriver.common.keys import Keys
from selenium import webdriver
from time import sleep
import sys

wait_time = 3


def sign_in(username, password):

    driver = webdriver.Chrome()
    driver.get('https://ehall.jlu.edu.cn')
    i = driver.find_element_by_id('username')
    i.send_keys(username)
    passwd = driver.find_element_by_id('password')
    passwd.send_keys(password)
    passwd.send_keys(Keys.RETURN)
    sub = driver.find_element_by_id('login-submit')
    sub.click()
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
            font = driver.find_element_by_xpath('//a[nobr="提交"]').click()
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
            driver.find_elements_by_tag_name('button')[-2].click()
        except Exception:
            interval += 1
    if interval > wait_time:
        print('confirm button not captured ! ')
        driver.quit()
        return
    driver.quit()


if __name__ == "__main__":
    sign_in(sys.argv[1], sys.argv[2])
