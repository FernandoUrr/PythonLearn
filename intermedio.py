def nested_dictionaries_and_lists():
    pass

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