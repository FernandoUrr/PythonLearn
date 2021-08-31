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

def run():
    menu = """
    Estos son los algoritmos de intermedio
    1. Nested dictionaries and lists
    2. 
    3. 
    4.
    5.
    6.
    7.
    Selecciona una opción:
    """
    a = int(input(menu))
    if a == 1:
        return nested_dictionaries_and_lists()

if __name__ == '__main__':
    run()