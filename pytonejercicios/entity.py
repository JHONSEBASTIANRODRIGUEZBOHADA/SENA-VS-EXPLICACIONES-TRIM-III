from msilib.schema import Property


class Pedido:
    #contructor
    def __init__(self,nombre,importe):
        selft.__nombre = nombre
        selft.__importe = importe
        selft.__impuesto = 0
        selft.__total = 0
        
    #Definir propiedad de lectura (en c# => get)
    @property
    def nombre(selft):
        return selft.__nombre
    
    @property
    def importe(selft):
        return selft.importe
    
    @property
    def total(selft):
        return selft.total
    
    @property
    def impuesto(selft):
        return selft.impuesto
    
    #Definir propiedad de asignacion (en c# => get)
    @nombre.setter
    def nombre(self,nombre):
        selft.nombre
        
    @importe.setter
    def importe(self,importe):
        selft.importe
        
    @total.setter
    def total(self,total):
        selft.total
        
    @impuesto.setter
    def impuesto(self,impuesto):
        selft.impuesto