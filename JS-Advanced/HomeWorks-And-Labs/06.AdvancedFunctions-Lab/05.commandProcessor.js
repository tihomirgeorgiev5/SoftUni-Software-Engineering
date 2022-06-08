function commProcessor () {
    let state = '';

    function append(str) {
        state += str;
    }

    function removeStart(n) {
        state = state.slice(n);
    }

    function removeEnd(n) {
        state = state.slice(0, -n);
    }

    function print (n) {
        console.log(state);
    }

    return {
        append,
        removeStart,
        removeEnd,
        print
    };

    
}

const firstZeroTest = commProcessor();
firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.removeStart(3);
firstZeroTest.removeEnd(4);
firstZeroTest.print();