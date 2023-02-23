dog_food_qty = float(input())
cat_food_qty = float(input())

dog_food_prc = 2.5
cat_food_prc = 4

total_dog_food_prc = dog_food_qty * dog_food_prc
total_cat_food_prc = cat_food_qty * cat_food_prc
total_food_prc = total_dog_food_prc + total_cat_food_prc

print(f"{total_food_prc} lv.")
