
screening_type = input()
rows = int(input())
cols = int(input())
total_price = 0

cinema_capacity = rows * cols

if screening_type == 'Premiere':
    total_price = cinema_capacity * 12
elif screening_type == 'Normal':
    total_price = cinema_capacity * 7.50
elif screening_type == 'Discount':
    total_price = cinema_capacity * 5

print(f"{total_price:.2f} leva")
