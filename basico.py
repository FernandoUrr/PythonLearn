import random

def conversor_de_monedas():
    def conversor(tipo_pesos, valor_dolar):
        pesos = float(input(f'¿Cuantos pesos {tipo_pesos} tienes?: '))
        dolares = str(round(pesos/valor_dolar,2))
        print(f'Tienes $ {dolares} dólares')

    opcion = """
    Bienvenido al conversor de monedas
    1- Pesos colombianos
    2- Pesos argentinos
    3- Pesos mexicanos

    Elige una opción: """

    option = int(input(opcion))
    if option == 1:
        conversor("colombianos", 3875)
    elif option == 2:
        conversor("argentinos", 65)
    elif option == 3:
        conversor("mexicanos", 24)
    else:
        print('Seleccione una opción válida')


def palindrome():
    word = str(input('Escribe una palabra: '))
    a = word.lower().replace(' ','')
    b = a[::-1]
    if a == b:
        return print(f'{word} es palíndromo!')
    else:
        return print(f'{word} no es palíndromo!')

    

def prueba_primalidad():
    def es_primo(numero):
        contador = 0
        for i in range(1,numero +1):
            if i == 1 or i == numero:
                continue
            if numero%i ==0:
                contador += 1
        
        if contador ==0:
            return True
        else:
            return False

    num = int(input('Escribe un número: '))
    if es_primo(num):
        print(f'{num} es primo')
    else:
        print(f'{num} es primo')

def prueba_primalidad2():
    def es_primo(numero):
        if (3**(numero-1))%numero == 1:
            return print('Es primo')
        else:
            if numero == 3:
                return('Es primo')
            else:
                return print('No es primo')
    
    num = int(input('Escribe un número: '))
    es_primo(num)
    #Tener en cuenta los números de Fermat

def adivina_el_numero():
    numero_aleatorio = random.randint(1,100)
    numero_elegido = int(input('Elige un número del 1 al 100: '))
    while numero_elegido != numero_aleatorio:
        if numero_elegido < numero_aleatorio:
            print('Busca un número más grande')
        else:
            print('Busca un número más pequeño')
            numero_elegido = int(input('Elige otro número: '))
    print('¡Ganaste!')
    
def pwd_generator():
    def pwd_generatorr():
        mayus = ['A','B', 'C', 'D', 'E', 'F', 'G']
        minus = ['a', 'b', 'c', 'd', 'e', 'f', 'g']
        simbols = ['!', '#', '$', '/']
        numeros =[str(i) for i in range(0,10)]

        characters = mayus + minus + simbols + numeros

        contrasena = [random.choice(characters) for i in range (15)]
        return ''.join(contrasena)

    contrasena = pwd_generatorr()
    return print(f'Tu nueva contrasena es: {contrasena}')





# function_list = [conversor_de_monedas(), palindrome(), prueba_primalidad(), adivina_el_numero(), pwd_generator()]

def menu():
    a = """
    Curso Básico de Python
    1. Conversor de monedas
    2. Palabras palíndromo
    3. Prueba de primalidad
    4. Adivina el número
    5. Generador de contraseñas
    Elija una opción: """
    b = int(input(a))
    if b == 1:
        return conversor_de_monedas()
    elif b == 2:
        return palindrome()
    elif b == 3:
        return prueba_primalidad()
    elif b == 4:
        return adivina_el_numero()
    else:
        return pwd_generator()


    

if __name__ == '__main__':
    menu()