import math
from typing import Sequence
from functools import reduce

def nested_dictionaries_and_lists():
    my_list = [1, "Hello", True, 4.5]
    my_dict = {"firstname": "Facundo", "lastname": "GarcÃ­a"}

    super_list = [
        {"firstname": "Facundo", "lastname": "GarcÃ­a"},
        {"firstname": "Miguel", "lastname": "Rodriguez"},
        {"firstname": "Pablo", "lastname": "Trinidad"},
        {"firstname": "Susana", "lastname": "Martinez"},
        {"firstname": "JosÃ©", "lastname": "Fernandez"},
    ]

    super_dict = {
        "natural_nums": [1, 2, 3, 4, 5],
        "integer_nums": [-1, -2, 3, 0, 1],
        "floating_nums": [1.1, 4.55, 6.43],
    }

    for key, value in super_dict.items():
        print(key, ">", value)

    for index in super_list:
        print

def list_comprehensions():
    l = [i for i in range(1, 10000) if i%36 == 0]
    return print(l)

def dict_comprehensions():
    my_dict = {i: round(math.sqrt(i), 5) for i in range(1,1001) if i % 3 != 0}
    return print(my_dict)

def lambda_functions():
    #Palindrome example
    # Esta es una función sin nombre, va a retornar el valor verdadero
    palindrome = lambda string: string == string[::-1]
    # Contraparte bastante más larga
    def palindrome(string):
        return string == string[::-1]
    

    #High order functions 
    #Ejemplo con Filter
    my_list = [1, 4, 5, 6, 13, 19, 21]
    odd1 = [i for i in my_list if i % 2 != 0]
    odd2 = list(filter(lambda x: x % 2 != 0, my_list))
    #Ejemplo con map
    my_list2 = [i for i in range(1,6)]
    squares1 = [i**2 for i in my_list2]
    squares2 = list(map(lambda x: x**2, my_list2))
    #Ejemplo con reduce
    my_list3 = [2, 2, 2, 2, 2]
    all_multiplied = 1
    for i in my_list:
        all_multiplied = all_multiplied*i
    
    all_multiplied2 = reduce(lambda a, b: a * b, my_list3)
    return print(odd1, "- Con el filter ->", odd2), print(squares1,'- Esto es con map ->', squares2), print(all_multiplied, '- Esto es con reduce ->', all_multiplied2)



    

def run():
    menu = """
    Estos son los algoritmos de intermedio
    1. Nested dictionaries and lists
    2. List comprehensions
    3. Dict comprehensions
    4. Lambda Functions and High Order Functions
    5. El resto de cosas revisarla en el ipython
    Selecciona una opción:
    """
    a = int(input(menu))
    if a == 1:
        return nested_dictionaries_and_lists()
    elif a == 2:
        return list_comprehensions()
    elif a == 3:
        return dict_comprehensions()
    elif a == 4:
        return lambda_functions()

if __name__ == '__main__':
    run()