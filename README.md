# pythonnet_sample
### consume python function from c# app

how to install pythonnet and work with vs2017
-----------------------------------------------

1. go to this url : https://ci.appveyor.com/project/pythonnet/pythonnet/branch/master
   
     (i) click on this link:  "Environment: PYTHON_VERSION=3.7; Platform: x64"
	 
	 (ii) click on artifact menu
	 
	 (iii) download "dist\pythonnet-2.4.0.dev0-cp37-cp37m-win_amd64.whl" this whl file and then run in cmd "pip install [whl file name]" (assuming you have installed python 3.7 on your windows machine. if you feel any difficulties to install python then visit this url: https://www.howtogeek.com/197947/how-to-install-python-on-windows/)
	 
	 
2. create visual studio c# project and add referecnces "Python.Runtime.dll" from python37 -> Lib -> site-packages directory.(if you don't know where python is install , just run in cmd "python -m site" , if you have both python 2.7 and 3.7 also then you may need to type "py -3 -m site" for python 3.7 and "py -2 -m site" for python 2.7)

3. add "PYTHON35,UCS2" conditional compilation symbol from c# project properties -> Build menu

4. create a sample.py file in python37 -> Lib -> site-packages directory and import as  Py.Import("sample")
