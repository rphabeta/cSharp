1. Add 메서드: List에 요소를 추가한다.
  List<string> fruits = new List<string>();
  fruits.Add("Apple");
  fruits.Add("Banana"); 
  fruits.Add("Orange");

2. Remove 메서드: List에 지정된 요소를 제거한다.
  List<string> fruits = new List<string>() { "Apple", "Banana", "Orange" };
  fruits.Remove("Banana");

3. Count 속성: List에 포함된 요소의 개수를 가져온다.
  List<string> fruits = new List<string> {"Apple", "Banana", "Orange"};
  int count = fruits.Count;   

4. Contains 메서드: 지정된 요소가 List에 있는지 여부를 확인한다.
  List<string> fruits = new List<string>() {"Apple", "Banana", "Orange"};
  bool containsBanana = fruits.Contains("Banana");

5. Sort 메서드: List의 요소를 정렬한다.
  List<int> numbers = new List<int>() { 5, 2, 7, 1, 3};
  numbers.Sort();
    5.1 Sort 메서드(시용자 정의 비교자): List의 요소를 사용자가 정의한 비교자를 사용하여 정렬한다.
      List<string> fruits = new List<sting>() { "Apple", "Banana", "Orange" };
      fruits.Sort((x, y) => y.CompareTo(x));

6. Find 메서드: 지정된 조건을 만족하는 첫 번째 요소를 찾는다.
  List<int> numbers = new List<int>() { 5, 2, 7, 1, 3};
  int foundNumber = numbers.Find(x => x > 3);

7. Insert 메서드: 지정된 인덱스 요소를 삽입한다.
  List<string> fruits = new List<string>() { "Apple", "Banana", "Orange" };
  fruits.Insert(1, "Mango");

8. Clear 메서드: List의 모든 요소를 제거한다.
  List<string> fruits = new List<string>() { "Apple", "Banana", "Orange" };
  fruits.Clear();

9. FindAll 메서드: 지정된 조건을 만족하는 모든 요소를 찾아 list로 반환한다.
  List<int> numbers = new List<int>() { 5, 2, 7, 1, 3 };
  List<int> foundNumbers = numbers.FindAll(x => x > 3);

10. Reverse 메서드: List의 순서를 역순으로 변경한다.
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
  numbers.Reverse();

11. IndexOf 메서드: 지정된 요소의 첫 번째 인덱스를 반환한다.
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5};
  List<int> range = numbers.GetRange(1, 3);

12. RemoveAt 메서드: 지정된 인덱스에 있는 요소를 제거한다.
  List<string> fruits = new List<string>() { "Apple", "Banana", "Orange" };
  fruits.RemoveAt(1);

13. Exists 메서드: 지정된 조건을 만족하는 요소가 있는지 여부 확인
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
  bool exists = numbers.Exists(x => x > 3);

14. TrueForAll 메서드: 모든 요소가 지정된 조건을 만족하는지 여부를 확인한다.
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
  bool allGreaterThabZero = numbers.TrueForAll(x => x > 0);

15. ConvertAll 메서드: List의 모든 요소를 새로운 형식으로 변환한다.
  List<string> fruits = new List<string>() {"Apple", "Banana", "Orange" };
  List<int> lengths = fruits.ConvertAll(x => x.Length);

16. FindIndex 메서드: 지정된 조건을 만족하는 첫 번째 요소의 인덱스를 찾는다.
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
  int index = numbers.FindIndex(x => x > 3);

17. RemoveAll 메서드: 지정된 조건을 만족하는 모든 요소를 제거한다.
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5};
  numbers.RemoveAll(x => x % 2 == 0);

18. FindLast 메서드: 지정된 조건을 만족하는 마지막 요소를 찾는다.
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
  int lastNumber = numbers.FindLast(x => x % 2 == 0);

19. BinarySearch 메서드: List에서 이진 검색을 수행해서 지정된 요소를 찾는다. (리스트가 정렬되어 있어야 한다.)
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5};
  int index = numbers.BinarySearch(3);

20. TimeExcess 메서드: List의 용량을 현재 요소 수에 맞게 조정한다.
  List<string> fruits = new List<string>() { "Apple", "Banana", "Orange" };
  fruits.TrimExcess();

21. ToArray 메서드: List의 요소를 배열로 복사한다.
  List<int> numbers = new List<int>() { 1, 2, 3, 4, 5};
  int[] numberArray = numbers.ToArray();

22. TrueForAny 메서드: 지정된 조건을 만족하는 요소가 하나 이상 있는지 여부를 확인한다.
  List<int> nunbers = new List<int>() { 1, 2, 3, 4, 5 };
  bool hasEvenNumber = numbers.TrueForAny(x => x % 2 == 0);
