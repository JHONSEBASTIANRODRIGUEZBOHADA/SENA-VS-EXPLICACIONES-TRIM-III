from controller import *
from util import *

class Prueba:
    #ingresar datos
    nombre = input("ingese el nombre del proveedor")
    importe = float(input('ingrese el importe : '))
    #crear objeto de la clase pedido
    pe = Pedido(nombre,importe)
    #crear objeto de la calse pedidocontroller
    obj = PedidoController()
    #procesar
    bolate = obj.procesarPedido(pe)
    #imprimir boleta
    print(RAYA)
    print(boleta)
    print(RAYA)
    
    
    #crear objeto de la clase prueba
    p = Prueba()