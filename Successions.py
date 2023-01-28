print("Succesions")

#Introducir la distancia entre los numeros de la sucesión
distance=int (input("Introduce the distance between the numbers in the succession: "))
#Introducir el número con el que comenzara la sucesión
FirstNum=int (input("Introduce the first number of the succesion: "))
#Introducir la posición final en donde terminará la sucesión
FinalPos= int(input("Introduce de final postion of the succesion: "))

#Estas variables toman el valor de las anteriores variables, porque con el for se modificaran, y asi guardamos su valor inicial para despues
d=distance
a1=FirstNum
an=FinalPos

#For terminará cuando -i- sea igual a la posición final
for i in range (FinalPos):
    #Solo es para escribir el número desde donde comenzara la sucesión
    if i==0:
        print(" ")
        print(FirstNum)
    else:
        #Aquí se escribe la suceción
        Variable=FirstNum+distance
        print(Variable)
        FirstNum=Variable

#     SUMA DE -N- TERMINOS

#Aqui se encuentra si el numero se sumara o restara
x=a1-d

# a1 = posición inicial
# d=distancia entre numero
# an=posicion final  
Addition=((a1+((d*an)+x))*an)/2
print(" ")
print("Suma de toda la sucesión ", Addition)