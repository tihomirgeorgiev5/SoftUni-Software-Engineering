nylon = int(input())
paint = int(input())
paint_thinner = int(input())
hours = int(input())

nylon_price = 1.50
paint_price = 14.50
paint_thinner_price = 5.00

bags_price = 0.40

nylon_sum = (nylon + 2) * nylon_price
paint_sum = (paint + (paint * 0.10)) * paint_price
paint_thinner_sum = paint_thinner * paint_thinner_price

total_material_price = nylon_sum + paint_sum + paint_thinner_sum + bags_price
workers_sum = (total_material_price * 0.30) * hours
total_sum = total_material_price + workers_sum

print(total_sum)





