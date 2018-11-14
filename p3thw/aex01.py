steps_count = 2_260_006
f_steps_count = "{:,}".format(steps_count)
days_count = 45 * 7 + 3
average_spd = steps_count / days_count
f_average_spd = str(round(average_spd, 2))

print(f"Walking {f_steps_count} steps in {days_count} days averages {f_average_spd} steps per day.")
