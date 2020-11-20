CXX := g++
CXXFLAGS := -ansi -O2 -march=x86-64 -pipe

default: calculatortutorial.exe

calculatortutorial.exe: calculatortutorial.cpp calculator.o
	$(CXX) $(CXXFLAGS) calculatortutorial.cpp calculator.o -o calculatortutorial.exe

calculator.o: calculator.cpp
	$(CXX) $(CXXFLAGS) -c calculator.cpp -o calculator.o

clean:
	-rm -f calculator.o
	-rm -f calculatortutorial.exe
