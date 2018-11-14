using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace III_upr6
{
    class ParagraphParser
    {

        List<TextWord> parsedParagraph;
        private int maxWordLength = 0; // IF WE WANT TO REDUCE THE LENGTH OF THE MAX WORD
        private string blackList = ": ` ,  as ( ) at ? ! @ # $ % ^ & * or is to are to for { } [ ]";
        private string whiteListOfTags = "html title head body a p h1 h2 h3 h4 h5 h6 ";

        private string lastFoundLink = "";

        Stack<string> myStack = new Stack<string>();

        private int parserIterator = 0;
        private string currentParagraph = "";
        private char currentSingleChar = ' ';

        Queue<string> errors = new Queue<string>();

        StringBuilder wordBuffer = new StringBuilder();

        public ParagraphParser(string inputParagraph)
        {

            parsedParagraph = ParagraphParse(inputParagraph);

        }

        public List<TextWord> ParagraphParse(string paragraph)
        {

            currentParagraph = paragraph;

            List<TextWord> outputParagraph = new List<TextWord>();
            wordBuffer = new StringBuilder();


            int currentChar = 0; // char counter
            for (parserIterator = 0; parserIterator < currentParagraph.Length; parserIterator++)
            {
                char singleChar = currentParagraph[parserIterator];

                if (singleChar == '"') // When we have a string starter
                {
                    tokenizeTag('"', '"');

                }
                else if (singleChar == '<') {
                    printIfLengthFits(outputParagraph);
                    tokenizeTag('<', '>');
                    printIfLengthFits(outputParagraph);
                }
                else if (
                    char.IsWhiteSpace(singleChar) ||
                    isCharInBlackList(singleChar.ToString())
                )
                {

                    // printIfLengthFits(wordBuffer, outputParagraph);
                    if(wordBuffer.Length > 0)
                    {
                        wordBuffer.Append(singleChar);
                    }

                }
                else
                {
                    wordBuffer.Append(singleChar);
                }

                currentChar++; // count the characters
            }
            

            printIfLengthFits(outputParagraph);

            return outputParagraph;
        }

        private string handleTagAttributes()
        {
            string currentTag = wordBuffer.ToString();
            string currentTagName = getTagName(wordBuffer.ToString());

            string tagValue = "";

            string currentWord;

            if(currentTagName == "a")
            {
                for (int i = 0; i < wordBuffer.Length; i++)
                {

                    if(currentTag[i] == '"')
                    {
                        i++;
                        while (currentTag[i] != '"')
                        {
                            tagValue += currentTag[i];
                            i++;

                            if (i >= wordBuffer.Length)
                            {
                                errors.Enqueue("ERROR: STRING Not Closed!!!");
                                break;
                            }
                        }
                    }

                }
            }

            return tagValue;

        }

        private void tokenizeTag(char startSymbol, char endSymbol)
        {
            char singleChar = currentParagraph[parserIterator];

            wordBuffer.Append(singleChar);
            parserIterator++;
            singleChar = currentParagraph[parserIterator];
            while (singleChar != endSymbol)

            {
                wordBuffer.Append(singleChar);
                parserIterator++;

                if (parserIterator >= currentParagraph.Length)
                {
                    errors.Enqueue("ERROR: Tag Not Closed!!!");
                    break;
                }
                singleChar = currentParagraph[parserIterator];


            }
            wordBuffer.Append(singleChar);
        }

        public bool isSpecialSymbol(char testedChar)
        {
            bool result = false;

            char[] array1 = { ';', '-', '+', '.' };

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == testedChar)
                {
                    return true;
                }
            }

            return result;
        }

        private string getTagName(string tag)
        {
            string result = "";

            for(int i= 0; i < tag.Length; i++)
            {

                if (char.IsWhiteSpace(tag[i]) || tag[i] == '>')
                {
                    break;
                }
                if(tag[i] != '<' && tag[i] != '/')
                {
                    result += tag[i];
                }

                
            }

            return result;
        }

        private void printIfLengthFits(List<TextWord> outputParagraph)
        {
            string currentWord = wordBuffer.ToString().ToLower();

            string wordType = determineWordType(wordBuffer.ToString().ToLower());

            string asdf = (wordType.Length > 12)? wordType.Substring(0, 13) : wordType;
            if (asdf == "Starting  Tag")
            {

                if (isCharInWhiteList(getTagName(wordBuffer.ToString())))
                {
                    myStack.Push(getTagName(wordBuffer.ToString()));
                }
                else
                {
                    errors.Enqueue("ERROR: Unallowed symbol(" + wordBuffer.ToString() + " ) on position " + (parserIterator - wordBuffer.Length + 1));
                    wordBuffer.Clear();
                    return;
                }

                
            }

            if(wordType == "Closing Tag")
            {
                if (isCharInWhiteList(getTagName(wordBuffer.ToString())))
                {
                    
                }
                else
                {
                    errors.Enqueue("ERROR: Unallowed symbol(" + wordBuffer.ToString() + " ) on position " + (parserIterator - wordBuffer.Length + 1));
                    wordBuffer.Clear();
                    return;
                }

                if ( myStack.Count == 0)
                {
                    errors.Enqueue("ERROR: Unwanted Closing Tag On Position " + (parserIterator - wordBuffer.Length + 1));
                    wordBuffer.Clear();
                    return;
                }
                else
                {
                    string lastStackElement = myStack.Peek();
                    string currentStackElemnt = getTagName(wordBuffer.ToString());

                    if (lastStackElement != currentStackElemnt)
                    {
                        errors.Enqueue("ERROR: Unwanted Closing Tag On Position " + (parserIterator - wordBuffer.Length + 1));
                        wordBuffer.Clear();
                        return;
                    }
                    else
                    {
                        myStack.Pop();
                    }
                }

                
            }

            if (!isCharInBlackList(currentWord) && currentWord.Length > maxWordLength)
            {
                outputParagraph.Add(
                    new TextWord(currentWord, wordType)
                );
            }
            
            wordBuffer.Clear();
        }

        private bool isCharInBlackList(string word)
        {
            bool result = false;

            StringBuilder wordBuffer = new StringBuilder();

            for (int i = 0; i < blackList.Length; i++)
            {
                if (char.IsWhiteSpace(blackList[i]) && wordBuffer.Length > 0)
                {
                    if (word == wordBuffer.ToString())
                    {
                        result = true;
                        return result;
                    }
                    wordBuffer.Clear();
                }
                else
                {
                    wordBuffer.Append(blackList[i]);
                }
            }

            return result;
        }

        private bool isCharInWhiteList(string word)
        {
            bool result = false;

            StringBuilder wordBuffer = new StringBuilder();

            for (int i = 0; i < whiteListOfTags.Length; i++)
            {
                if (char.IsWhiteSpace(whiteListOfTags[i]) && wordBuffer.Length > 0)
                {
                    if (word == wordBuffer.ToString())
                    {
                        result = true;
                        return result;
                    }
                    wordBuffer.Clear();
                }
                else
                {
                    wordBuffer.Append(whiteListOfTags[i]);
                }
            }

            return result;
        }

        private string determineWordType(string word)
        {
            string type = "Text";

            if (word.Length > 1)
            {
                if (word[0] == '"' && word[word.Length - 1] == '"')
                {
                    type = "String";
                }

                if (word[0] == '<' && word[word.Length - 1] == '>')
                {
                    type = "Starting  Tag";

                    if (getTagName(word) == "a" && handleTagAttributes().Length > 1)
                    {

                        string a = handleTagAttributes();
                        lastFoundLink = a;
                        type = "Starting  Tag, URL: " + a;

                    }

                    if (word[1] == '/')
                    {
                        type = "Closing Tag";
                    }
                }
            }
			int n;
            if (int.TryParse(word, out n))
            {
                type = "Intconst";
            }

            if (word == "+")
            {
                type = "Plus";
            }

            if (word == "-")
            {
                type = "Minus";
            }

            if (word == ";")
            {
                type = "Semicolumn";
            }

            if (word == ".")
            {
                type = "Period";
            }

            if (word == "'")
            {
                type = "Quote";
            }

            return type;
        }

        public List<TextWord> getParsedParagraph()
        {
            return parsedParagraph;
        }

        public int getParagraphLength()
        {
            return parsedParagraph.Count();
        }

        public void printCurrentParagraphToTextBox(TextBox box)
        {
            foreach (TextWord textWord in parsedParagraph)
            {
                box.AppendText(textWord.word + "\n");
            }
        }

        public void printCurrentParagraphToTextBoxSpaced(TextBox box)
        {
            foreach (TextWord textWord in parsedParagraph)
            {
                box.AppendText(textWord.word + " ");
            }
        }


        public void printCurrentParagraphToTextBoxWithType(TextBox box)
        {
            foreach (TextWord textWord in parsedParagraph)
            {
                box.AppendText(textWord.word + " => " + textWord.type + "\n");
            }

            if(errors.Count > 0)
            {
                string message = "";
                string title = "You Have Some PROBLEMS!";
                foreach (string error in errors)
                {
                    message += error + '\n';
                }

                MessageBox.Show(message, title);
            }
        }

        internal class TextWord
        {
            public string word { set; get; }
            public string type { set; get; }

            public TextWord(string wordInput, string wordTypeInput)
            {
                word = wordInput;
                type = wordTypeInput;
            }
        }

    }
}
