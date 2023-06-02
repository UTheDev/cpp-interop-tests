cmake_minimum_required(VERSION 3.0.0)
project(cpp-interop-tests VERSION 0.1.0)

include(CTest)
enable_testing()

#add_executable(cpp_interop_tests src/native/main.cpp)

# see https://stackoverflow.com/questions/6499364/generating-dll-using-cmake
add_library(window_test SHARED src/native/WindowTest.cpp)

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
include(CPack)
