deposit_sum = float(input())
deposit_range = int(input())
yearly_rate = float(input())

yearly_rate_percent = yearly_rate / 100

mySum = deposit_sum + deposit_range * ((deposit_sum * yearly_rate_percent) / 12)

print(mySum)
