/*
 * calculator.cpp
 *
 * Copyright 2020 Samgo <Samgo@DESKTOP-198PM1N>
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301, USA.
 *
 *
 */

#include <iostream>
#include "calculator.h"

int main()
{
    double x = 0.0;
    double y = 0.0;
    double result = 0.0;
    char oper = '+';

    std::cout << "Calculator Console Application" << std::endl << std::endl;
    std::cout << "Please enter the operation to perform. Format: a+b | a-b |a*b | a/b"
              << std::endl;

    Calculator c;
    while (true)
    {
        std::cin >> x >> oper >> y;
        if (oper == '/' && y == 0)
        {
            std::cout << "Division by 0 exception" << std::endl;
        }
        else
        {
            result = c.Calculate(x, oper, y);
        }
        std::cout << "Result is: " << result << std::endl;
    }

    return 0;
}

