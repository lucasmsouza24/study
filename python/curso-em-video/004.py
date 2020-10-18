value = input('Insert any value: ')

print(f'Type: {type(value)}')
print(f'Numeric: {value.isnumeric()}')
print(f'Alpha: {value.isalpha()}')
print(f'Alphanumeric: {value.isalnum()}')
print(f'Decimal: {value.isdecimal()}')
print(f'Digit: {value.isdigit()}')