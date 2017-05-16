#!/bin/tcsh

# (1) Set some variables
setenv PROJECT_HOME /Users/mohammed/Projects/auto

# (2) Start the server
setenv x `ps -ef | grep server.py | grep 9999 | wc -l`
if ($x == 0) then
  cd ${PROJECT_HOME}/server
  python server.py 9999 
endif

# (3) Return back
cd ${PROJECT_HOME}

