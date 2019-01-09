# pythonnet_sample
###consume python function from c# app

how to install pythonnet
----------------------------

1. go to this url : https://ci.appveyor.com/project/pythonnet/pythonnet/branch/master
   
     (i) click on this link:  "Environment: PYTHON_VERSION=3.7; Platform: x64"
	 
	 (ii) click on artifact menu
	 
	 (iii) download "dist\pythonnet-2.4.0.dev0-cp37-cp37m-win_amd64.whl" this whl file and then run in cmd "pip install [whl file name]"
	 
	 
2. create visual studio c# project and add referecnces "Python.Runtime.dll"	  from python37 -> sitepackages directory

3. add "PYTHON35,UCS2" conditional compilation symbol from c# project properties -> Build menu

4. create a sample.py file in python37 -> sitepackages directory and import as  Py.Import("sample")
