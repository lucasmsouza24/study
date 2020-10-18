#06

# preços de produtos
p_chopp = 0.80
p_pizza = 10.0
p_cobertura = 1.5

# entrada de dados
print("Quantidade de pessoas:")
q_pessoas = int(input())

print("Quantidade de chopps:")
q_chopps = int(input())
      
print("Quantidade de coberturas:")
q_coberturas = int(input())
      
# preço do pedido
preco_pedido = p_pizza + (p_chopp * q_chopps) + (p_cobertura * q_coberturas)

# preço total
preco_liquido = preco_pedido + (preco_pedido * 0.10)

# valor pago por cada pessoa
preco_pessoa = preco_liquido / q_pessoas

print("Valor pedido:", preco_pedido)
print("10% garçom:",preco_pedido * 0.10)
print("Valor total:", preco_liquido)
print("Cada um vai pagar:", preco_pessoa)
