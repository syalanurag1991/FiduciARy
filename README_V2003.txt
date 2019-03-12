/*  PerspectiveImageCorrection (c) W. Schroeder 01/2013
   
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>. */


-This Project needs the .NET Framework 3.5 !

// 12.10.2015: Version 1.0.0.5
// - Zoom Fit and Zooming for mice without wheel.
// - Image zoomes to fit after loading

// 15.10.2015: Version 1.0.0.6
// - Saving default path+Filename is the Source Path and filename of the image
// - Using "exiftool" call to copy exif information from the source file to the destination file


// 19.12.2015: Version 1.0.0.7
// CvInvoke.cvWarpPerspective(... flags = 4 instead of 0)
// Interpolation Method changed -> Lines are better converted 

// 27.03.2016: Version 1.0.0.8
// Options -> Copy rectified Image to Clipboard implemented
// (Not the smallest size)

// 17.07.2016 : Version 2.0.0.0
// Camera calibration for any lens implemented by using photos of chessboards for calibration 

// 19.02.2017 : Version 2.0.0.1
// -> Some users reported file load problems (On Windows 10?) The load-file error message
//    I therefore extended by some information, because I could not simulate that error until now.

// 20.02.2017 : Version 2.0.0.2
// -> Added merged Modules VC 2010 C++ redist to avoid separate installation of VC2010 C++ redist package

// 01.05.2017 : Version 2.0.0.3
// opencv_gpu242.dll added to Setup