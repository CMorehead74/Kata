# Kata
A file's hash value is essentially a string of numbers and letters of fixed length, that functions as a cryptographic fingerprint for that file.

File hashes are commonly used in cyber security to identify different strains of malware, with a unique hash value corresponding to each malware file.

Your junior analyst has just sent you a list of new malware hashes, but you know he has made mistakes entering them. Write a function to validate the array of hash values.

In this scenario, a valid hash value consists of five numbers and five lowercase letters in any order.

Return an array of valid hash values, and eliminate any duplicates.

Example passing test case:
Input: ['asdfiasdfg', "jsdfasdf14", "a212sdf345", "as00yud567", "as34asd567", "agsdgreast", "1dfg23asd4", "hjkjw98076", "fdsqweqrah", "12gh34gh1g"])
Output: [ 'as00yud567', 'as34asd567', 'hjkjw98076', '12gh34gh1g' ]
