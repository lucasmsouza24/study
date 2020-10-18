print('='*25)
print('Variável a ser enontrada')
print('='*25)
print('1 - D')
print('2 - d')
print('3 - q')
print('4 - r')
print('='*25)
resposta = input('Escolha a variavel: ')
if resposta == '1':
	d = float(input('d: '))
	q = float(input('q: '))
	r = float(input('r: '))
	D = (d * q) + r
	print(f'D = (d * q) + r\nD = ({d} * {q}) + {r}\nD = {d * q} + {r}\nD = {D}')

if resposta == '2':
	pass

if resposta == '3':
	pass

if resposta == '4':
	pass
