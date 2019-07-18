- Operator

Removes one instance of each value of a CustomList from another CustomList

public static CustomList<T> operator- (CustomList<T> listOne, CustomList<T> listTwo)

Parameters:
	CustomList<T> listOne - The list that is being modified* 
		*Note: list is not actually modified, but instead is cloned, and the close is then modified and returned
	CustomList<T> listTwo - The list containing values that will be removed from the first list
	
Returns:
	CustomList<T> containing the updated version of listOne with values from listTwo removed
	
Example:
	int[] firstVals = new int[3] {0, 1, 2};
	int[] secondVals = new int[3] {2, 3, 4};
	CustomList<int> listOne = new CustomList<T>(firstVals);
	CustomList<int> listTwo = new CustomList<T>(secondVals);
	CustomList<int> outList = new CustomList<T>();
	outList = listOne - listTwo;
	
	// outList now reads {0, 1}