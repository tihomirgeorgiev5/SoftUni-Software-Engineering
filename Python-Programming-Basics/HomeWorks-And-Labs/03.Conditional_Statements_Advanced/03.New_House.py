
type_flowers = input()
count_flowers = int(input())
budget = int(input())

total_price = 0

if type_flowers == 'Roses':
    total_price = count_flowers * 5
    if count_flowers > 80:
        total_price*= 0.90
elif type_flowers == 'Dahlias':
    total_price = count_flowers * 3.80
    if count_flowers > 90:
        total_price*= 0.85
elif type_flowers == 'Tulips':
    total_price = count_flowers * 2.80
    if count_flowers > 80:
        total_price*= 0.85
elif type_flowers == 'Narcissus':
    total_price = count_flowers * 3
    if count_flowers < 120:
        total_price*= 1.15
elif type_flowers == 'Gladiolus':
    total_price = count_flowers * 2.50
    if count_flowers < 80:
        total_price*= 1.20

rest_money = abs(total_price - budget)

if total_price<= budget:
    print(f"Hey, you have a great garden with {count_flowers} {type_flowers} and {rest_money:.2f} leva left.")
else:
    print(f"Not enough money, you need {rest_money:.2f} leva more.")


