function encodeAndDecodeMessages() {
    const textAreas = document.querySelectorAll('textarea');
    const inputArea = textAreas[0];
    const outputArea = textAreas[1];
    const buttons = document.querySelectorAll('button');
    const encodeBtn = buttons[0];
    const decodeBtn = buttons[1];
    encodeBtn.addEventListener('click', encode);
    decodeBtn.addEventListener('click', decode);

    function encode() {
       const encryptedMessageArray = [];
       const input = inputArea.value;

       for (let i = 0; i < input.length; i++) {
          const symb = input.charCodeAt(i);
          encryptedMessageArray.push(String.fromCharCode(symb + 1));
           
       }
       inputArea.value = '';
       outputArea.value = encryptedMessageArray.join('');
    }
    
    function decode() {
        const encrypted = outputArea.value;
        const decryptedMessageArray = [];

        for (let i = 0; i < encrypted.length; i++) {
            const symb = encrypted.charCodeAt(i);
            decryptedMessageArray.push(String.fromCharCode(symb - 1));
            
        }
        outputArea.value = decryptedMessageArray.join('');
    }
}