public class DynamicArray {
    private int[] array;
    private int capacity = 0;
    private int size = 0;

    public DynamicArray(int capacity) {
        array = new int[capacity];
        this.capacity = capacity; 
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i] = n;
    }

    public void PushBack(int n) {
        if (size == capacity){
            Resize();
        }
        array[size] = n;;
        size++;
    }

    public int PopBack() {
        var item = array[size - 1];
        size--;
        return item;
    }

    private void Resize() {
        capacity *= 2;
        var newArray = new int[capacity];
        
        for(int i = 0; i < array.Length; i++){
            newArray[i] = array[i];
        }

        array = newArray;
    }

    public int GetSize() {
        return size;
    }

    public int GetCapacity() {
        return capacity;
    }
}
