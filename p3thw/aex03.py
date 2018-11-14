from sys import argv

app, arg1, arg2 = argv
i_arg1 = int(arg1)
i_arg2 = int(arg2)
sum = i_arg1 + i_arg2

print("{} + {} = {}".format(arg1, arg2, sum))
