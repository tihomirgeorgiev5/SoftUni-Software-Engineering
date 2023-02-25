yearly_tax = int(input())

shoes_price = yearly_tax * 0.60
clothes_price = shoes_price - (shoes_price * 0.20)
ball_price = clothes_price / 4
accessoires_price = ball_price / 5

total_sum = shoes_price + clothes_price + ball_price + accessoires_price + yearly_tax
print(total_sum)