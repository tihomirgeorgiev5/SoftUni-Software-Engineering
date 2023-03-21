
product = input()
town = input()
qty = float(input())
result = 0.0

if town == 'Sofia':
    if product == 'coffee':
        result = qty * 0.50
    elif product == 'water':
        result = qty * 0.80
    elif product == 'beer':
        result = qty * 1.20
    elif product == 'sweets':
        result = qty * 1.45
    elif product == 'peanuts':
        result = qty * 1.60
elif town == 'Plovdiv':
    if product == 'coffee':
        result = qty * 0.40
    elif product == 'water':
        result = qty * 0.70
    elif product == 'beer':
        result = qty * 1.15
    elif product == 'sweets':
        result = qty * 1.30
    elif product == 'peanuts':
        result = qty * 1.50
elif town == 'Varna':
    if product == 'coffee':
        result = qty * 0.45
    elif product == 'water':
        result = qty * 0.70
    elif product == 'beer':
        result = qty * 1.10
    elif product == 'sweets':
        result = qty * 1.35
    elif product == 'peanuts':
        result = qty * 1.55

print(result)

