import pyttsx3
import os,random,sys,time
from selenium.webdriver.common.keys import Keys
from urllib.parse import urlparse
from selenium import webdriver
from bs4 import BeautifulSoup
from countdown import countdown
mesin = pyttsx3.init()
file = open("Welcome.txt")
bacafile = file.readlines()
bacabaris = bacafile[0],bacafile[1],bacafile[2],bacafile[3]
bicara = mesin.say(bacabaris)
bicara = mesin.runAndWait()
print(bicara)

namaaplikasi = "Botacs Pro\n"
versiaplikasi = "1.0"
devby = "Ananda Rauf Maududi"
devdate = "12 November 2020\n"

print(namaaplikasi)
print(versiaplikasi)
print(devby)
print(devdate)


class waktu():
   def waktumundur():

        menit = 0
        detik = 5
        
        countdown(menit,detik)
class Menubot():
    def menubot():
        print("Menu Botacs Pro\n")
        print()
        print("1.autocheck")
        print("2.followIGDev")
class Autocheck():
    def autocheck(self):
        waktu.waktumundur()
        print("bot berjalan\n")
        browser = webdriver.Chrome('webdriver/chromedriver.exe')
        bukalist = open("linkcom.txt")
        bacafile = bukalist.readlines()
        targeturl = bacafile[0]

        browser.get(targeturl)
        checkoutid = browser.find_element_by_class_name('btn btn-solid-primary btn--l YtgjXY')
        checoutid.send_keys('btn btn-solid-primary btn--l YtgjX')
        print("Berhasil Checkout")

class FollowIGDev():
    def followIGDev(self):
        browser1 = webdriver.Chrome('webdriver/chromedriver.exe')
        browser1.get("https://www.instagram.com/anandaraufm")

Menubot.menubot()
auto = Autocheck()
follow = FollowIGDev()

pilih = int(input("Pilih nomor dalam menu Botacs Pro:"))

if pilih==1:
    auto.autocheck()
elif pilih==2:
    follow.followIGDev()
else:
    exit()
