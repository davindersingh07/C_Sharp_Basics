Topic: 
------
CSharp Code to Create, Write, Read and Delete files on your Computer.

What is File?
-------------
A File is Simple a Collection of Data. Files are Stored in non-volatile memory of computer.
means they do not get erased/deleted when the power is turned off.

Text File:
---------
Text file can be computer code, document like Microsoft Word, document composed of text.

we store data in a file for several Reasons:
1. The Data in the file requires long term storage.
2. A file can be easily duplicated.
3. Files are easily tansported.
4. FIle storage is cheap. They do not take much space on computer.
5. The File System is part of the operating system that organizes files and provides a way to create access, modify and delete files.

 
Handling File IO Exceptions:
----------------------------
When Reading from a File:-
	1. The File doesn't exists.
	2. The File doesn't exists at the specified location.

When Writing to a File:-
	1. The File exists but is read-only.
	2. The path name is too long.
	3. The disk is full.


IOException class has the following sub classes to handle exceptions:
---------------------------------------------------------------------
1. DirectoryNotFoundException
2. EndOfStreamException
3. FileNotFoundException
4. FileLoadException
5. PathTooLongException