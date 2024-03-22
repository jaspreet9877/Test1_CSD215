printfn "Hello from F#"

// Defined the list of SALARIES
let salary_company = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

// Printed all the salaries
printfn "All the Salaries: %A" salary_company

// Filterd all the high-income salaries (> $100,000)
let salariesof_highincome = salary_company |> List.filter (fun x -> x > 100000)

// Function to calculate tax based on salary
let tax_calculation salary =

    if salary <= 49020 then float salary * 0.15

    else if salary > 49020 && salary <= 100000 then float salary * 0.25

    else float salary * 0.35

// Calculated tax for all salaries using map function
let tax = salary_company |> List.map tax_calculation

// Filterd salaries less than $49,020 and add $20,000
let updated_salaries = salary_company |> List.map (fun x -> if x < 49020 then x + 20000 else x)

// Sum of salaries between $50,000 and $100,000 using reduce/fold function
let sumof_middlesalaries = salary_company |> List.filter (fun x -> x >= 50000 && x <= 100000) |> List.fold (+) 0
printfn "Salaries of high income: %A" salariesof_highincome

printfn "Taxes: %A" tax

printfn "The updated salaries: %A" updated_salaries

printfn "Sum of Mid Salaries: %d" sumof_middlesalaries

printfn ""

// Tail Recursion

// Tail-recursive function to calculate the sum of multiples of 3 up to a given number
let rec sumof_multipleof_3 acc limit =

    if limit = 0 then acc

    else sumof_multipleof_3 (acc + limit) (limit - 3)

// Example usage
let result = sumof_multipleof_3 0 27
printfn "OUTPUT OF TAIL RECURSION="
printfn ""
printfn "SUM OF MULTIPLES OF 3 UP TO 27 : %d" result