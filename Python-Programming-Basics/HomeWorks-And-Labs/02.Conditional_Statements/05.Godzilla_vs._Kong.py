budget = float(input())
actors_count = int(input())
actors_clothes_price = float(input())

decor = budget * 0.10
total_clothes_price = actors_count * actors_clothes_price

if actors_count >= 150:
    total_clothes_price*= 0.90

total_price_for_movie = total_clothes_price + decor

left_money = abs(total_price_for_movie - budget)

if total_price_for_movie > budget:
    print("Not enough money!")
    print(f"Wingard needs {left_money:.2f} leva more.")
else:
    print("Action!")
    print(f"Wingard starts filming with {left_money:.2f} leva left.")