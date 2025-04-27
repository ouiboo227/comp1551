using System;
// Enables querying and manipulating collections
using System.Linq;
// Provides cryptographic services like encryption
using System.Security.Cryptography;
// Provides classes to work with text encoding
using System.Text;

namespace Coursework
{
// Handles all logic for validation, encoding, sorting, and encryption
// Defines the StringProcessing class containing all string manipulation logic
    public class StringProcessing
    {
// Stores the input string provided by the user
        private string inputString;
// Stores the integer shift value for encoding
        private int inputN;
// Temporary arrays used in merge sort
        private int[] L = new int[40], R = new int[40];

// Sets the input string and integer value
        public void SetInput(string inputString, int inputN)
        {
            this.inputString = inputString;
            this.inputN = inputN;
        }

// Validates the input string and shift value according to constraints
        public int ValidateInput()
        {
            int output = 7;
// Check if string length is between 1 and 40
            if (inputString.Length < 1 || inputString.Length > 40) output &= 5;
// Check if all characters are capital letters
            if (!inputString.All(c => c >= 'A' && c <= 'Z')) output &= 6;
// Check if integer N is between -25 and 25
            if (inputN < -25 || inputN > 25) output &= 3;
            return output;
        }

// Shifts each character in the input string by N positions with alphabet wrapping
        public string EncodeString()
        {
// Encoding logic: shift characters and wrap around if needed
            return new string(inputString.Select(c =>
                (char)((((c - 'A') + inputN) % 26 + 26) % 26 + 'A')).ToArray());
        }

// Gets ASCII codes of characters in the original input string
        public int[] GetAsciiValuesBeforeEncoding()
        {
            return inputString.Select(c => (int)c).ToArray();
        }

// Gets ASCII codes of characters after encoding
        public int[] GetAsciiValuesAfterEncoding()
        {
            return EncodeString().Select(c => (int)c).ToArray();
        }

// Recursively sorts an array using the merge sort algorithm
        public int[] MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int mid = (l + r) / 2;
                MergeSort(arr, l, mid);
                MergeSort(arr, mid + 1, r);
                Merge(arr, l, mid, r);
            }
            return arr;
        }

// Merges two sorted subarrays during merge sort
        private void Merge(int[] arr, int l, int mid, int r)
        {
            int n1 = mid - l + 1, n2 = r - mid;
            for (int i = 0; i < n1; i++) L[i] = arr[l + i];
            for (int j = 0; j < n2; j++) R[j] = arr[mid + 1 + j];

            int i1 = 0, i2 = 0, k = l;
            while (i1 < n1 && i2 < n2)
                arr[k++] = (L[i1] <= R[i2]) ? L[i1++] : R[i2++];
            while (i1 < n1) arr[k++] = L[i1++];
            while (i2 < n2) arr[k++] = R[i2++];
        }

// Encrypts the input string using AES encryption
        public string Encrypt()
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(inputN.ToString().PadRight(32).Substring(0, 32));
                aes.IV = new byte[16];
                var encryptor = aes.CreateEncryptor();
                var plainText = Encoding.UTF8.GetBytes(inputString + "|" + GetSHA256(inputString));
                var encrypted = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
                return Convert.ToBase64String(encrypted);
            }
        }

// Decrypts an AES-encrypted string and verifies its integrity
        public string Decrypt(string encryptedText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(inputN.ToString().PadRight(32).Substring(0, 32));
                aes.IV = new byte[16];
                var decryptor = aes.CreateDecryptor();
                var decryptedBytes = decryptor.TransformFinalBlock(Convert.FromBase64String(encryptedText), 0, Convert.FromBase64String(encryptedText).Length);
                var combined = Encoding.UTF8.GetString(decryptedBytes).Split('|');
                return GetSHA256(combined[0]) == combined[1] ? combined[0] : null;
            }
        }

// Computes a SHA-256 checksum of the input string
        private string GetSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(input))).Replace("-", "");
            }
        }
    }
}