import time

def linear_search(sequence, target):
    for i, val in enumerate(sequence):
        if val == target:
            return i
    return -1

def binary_search(sequence, target):
    left, right = 0, len(sequence) - 1
    while left <= right:
        mid = (left + right) // 2
        if sequence[mid] == target:
            return mid
        elif sequence[mid] < target:
            left = mid + 1
        else:
            right = mid - 1
    return -1

N = 100_000_000
data = range(N)

start = time.perf_counter()
linear_search(data, 0)
end = time.perf_counter()
print("Wyszukiwanie liniowe - pierwszy element:", f"{(end - start)*1000:.8f}", "milisekund")

start = time.perf_counter()
linear_search(data, N - 1)
end = time.perf_counter()
print("Wyszukiwanie liniowe - ostatni element:", f"{(end - start)*1000:.8f}", "milisekund")

start = time.perf_counter()
binary_search(data, 0)
end = time.perf_counter()
print("Wyszukiwanie binarne - pierwszy element:", f"{(end - start)*1000:.8f}", "milisekund")

start = time.perf_counter()
binary_search(data, N - 1)
end = time.perf_counter()
print("Wyszukiwanie binarne - ostatni element:", f"{(end - start)*1000:.8f}", "milisekund")