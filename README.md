# Sweeft-2

1. დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი და აბრუნებს
პალინდრომია თუ არა. (პალინდრომი არის ტექსტი რომელიც ერთნაირად
იკითხება ორივე მხრიდან).
bool sPalindrome(string text);

2. გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. დაწერეთ ფუნქცია, რომელსაც
გადაეცემა თანხა (თეთრებში) და აბრუნებს მონეტების მინიმალურ
რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.
int MinSplit(int amount);

3. მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან. დაწერეთ
ფუნქცია რომელსაც გადაეცემა ეს მასივი და აბრუნებს მინიმალურ მთელ
რიცხვს, რომელიც 0-ზე მეტია და ამ მასივში არ შედის.
int NotContains(int[] array);

4. მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან. დაწერეთ
ფუნქცია რომელიც აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად
სწორად დასმული.
bool IsProperly(string sequence);

მაგ: (()()) სწორი მიმდევრობაა, ())() არასწორია


5. გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2
საფეხურით. დაწერეთ ფუნქცია რომელიც დაითვლის n სართულზე ასვლის
ვარიანტების რაოდენობას.
int CountVariants(int stairCount);

6. გვაქვს Teacher ცხრილი, რომელსაც აქვს შემდეგი მახასიათებლები: სახელი,
გვარი, სქესი, საგანი. გვაქვს Pupil ცხრილი, რომელსაც აქვს შემდეგი
მახასიათებლები: სახელი, გვარი, სქესი, კლასი. ააგეთ ნებისმიერ რელაციურ
ბაზაში ისეთი დამოკიდებულება, რომელიც საშუალებას მოგვცემს, რომ
მასწავლებელმა ასწავლოს რამოდენიმე მოსწავლეს და ამავდროულად
მოსწავლეს ჰყავდეს რამდენიმე მასწავლებელი (როგორც რეალურ
ცხოვრებაში).

1. დაწერეთ sql რომელიც ააგებს შესაბამის table-ებს.
2. დაწერეთ sql რომელიც დააბრუნებს ყველა მასწავლებელს, რომელიც
ასწავლის მოსწავლეს, რომელის სახელია: „გიორგი“ .



7. დაწერეთ აპლიკაცია EntityFramework-ის (Code-First) გამოყენებით დავალება
6-ის მოცემულობით. დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა
მასწავლებელს, რომელიც ასწავლის მოსწავლეს, რომლის სახელია: „გიორგი“.
Teacher[] GetAllTeachersByStudent(string studentName);

8. მოცემულია Countries REST API ის მისამართი:
https://restcountries.com/v3.1/all, რომელიც აბრუნებს ინფორმაციას ქვეყნების
შესახებ. დაწერეთ ფუნქცია, რომელიც ყოველი ქვეყნისთვის შექმნის ტექსტურ
დოკუმენტს (.txt) სახელად {ქვეყნის_სახელი.txt}. თითოეულ დოკუმენტში
უნდა იყოს შევსებული ქვეყნის “region”, “subregion”, “latlng”, “area” და
“population” ველები.
void GenerateCountryDataFiles();
