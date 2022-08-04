from model import *
from util import *

class PedidoController:
    def __init__(selft):
        selft.__model = PedidoModel()
        
        #metodo genera boleta de pedido
        def procesarPedido(selft,pe): # pe es un objeto de la clase pedido
            self.__model.calcularPedido(pe)
            selft.__boleta = TITULO + '\n' + RAYA + \
                            '\nProveedor : ' + pe.nombre + \
                            '\nimporte : ' + str(pe.importe) + \
                            '\nimpuesto(18%) : ' + str(pe.impuesto) + \
                            '\ntotal a pagar : ' + str(pe.total)
            
            return selft.__boleta