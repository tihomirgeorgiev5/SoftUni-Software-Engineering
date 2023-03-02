trip_price = float(input())
puzzles_count = int(input())
dolls_count = int(input())
teddyBears_Count = int(input())
mignions_count = int(input())
trucks_count = int(input())

puzzle_price = 2.60
doll_price = 3
teddyBear_price = 4.10
mignion_price = 8.20
truck_price = 2

order_puzzles = puzzle_price * puzzles_count
order_dolls = doll_price * dolls_count
order_teddyBears = teddyBear_price * teddyBears_Count
order_mignions = mignion_price * mignions_count
order_trucks = truck_price * trucks_count

total_order_price = order_trucks + order_mignions + order_dolls + order_puzzles + order_teddyBears
total_order_count = puzzles_count + dolls_count + teddyBears_Count + mignions_count + trucks_count

if total_order_count >= 50:
    total_order_price *= 0.75

total_order_price *= 0.90

left_money = abs(trip_price - total_order_price)

if total_order_price >= trip_price:
    print(f"Yes! {left_money:.2f} lv left.")
else:
    print(f"Not enough money! {left_money:.2f} lv needed.")

