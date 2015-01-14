using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Util;

namespace Warp.Testing.Unit.Core
{
    [Subject("CheckArgument tests")]
    public class CheckArgumentTests
    {
        public class HumanReadableGenerator
        {
            public string GenerateId()
            {
                return Base36Encode((ulong) Stopwatch.GetTimestamp() / TimeSpan.TicksPerMillisecond);
            }

            private const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            private static readonly char[] charsArray = chars.ToCharArray();

            //public static long Base36Decode(string inputString)
            //{
            //    long result = 0;
            //    var pow = 0;
            //    for (var i = inputString.Length - 1; i >= 0; i--)
            //    {
            //        var c = inputString[i];
            //        var pos = chars.IndexOf(c);
            //        if (pos > -1)
            //            result += pos * (long)Math.Pow(chars.Length, pow);
            //        else
            //            return -1;
            //        pow++;
            //    }
            //    return result;
            //}

            public static string Base36Encode(ulong inputNumber)
            {
                var sb = new StringBuilder();

                do
                {
                    sb.Append(charsArray[inputNumber % (ulong)chars.Length]);
                    inputNumber /= (ulong)chars.Length;
                } 
                while (inputNumber != 0);

                var value = Reverse(sb.ToString());

                for (var i = 3; i < value.Length; i += 4)
                {
                    value = value.Insert(i, "-");
                }

                return value;
            }

            public static string Reverse(string s)
            {
                var charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }

        public class When_callin : WithSubject<HumanReadableGenerator>
        {
            Because of = () =>
            {
                for (var i = 0; i < 1000; i++)
                {
                    var time = Stopwatch.GetTimestamp();
                    _result.Add(new KeyValuePair<long, string>(time, HumanReadableGenerator.Base36Encode((ulong) time)));
                }
            };

            It should_throw_an_exception = () =>
            {
                var checkingList = new List<KeyValuePair<long, string>>();

                foreach (var r in _result)
                {
                    if (checkingList.All(c => c.Value != r.Value))
                    {
                        checkingList.Add(r);
                    }
                }

                checkingList.Count.ShouldEqual(_result.Count);
            };

            static List<KeyValuePair<long, string>> _result = new List<KeyValuePair<long, string>>(1000);
        }

        public class When_calling__NotNull__with_a_null_parameter : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotNull<object>(null, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentNullException>();
                _exception.ShouldContainErrorMessage("testParam");
            };

            static Exception _exception;
        }

        public class When_calling__NotNull__with_a_non_null_parameter : WithSubject<CheckArgument>
        {
            Because of = () => _result = CheckArgument.NotNull("BLAH", "testParam");

            It should_return_parameter = () => _result.ShouldEqual("BLAH");

            static string _result;
        }

        public class When_calling__NotNullAndHasItems__with_a_null_collection : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotNullAndHasItems<IEnumerable<object>>(null, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentNullException>();
                _exception.ShouldContainErrorMessage("testParam");
            };

            static Exception _exception;
        }

        public class When_calling__NotNullAndHasItems__with_an_empty_collection : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotNullAndHasItems(new object[0], "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Collection has no items.");
                _exception.ShouldContainErrorMessage("testParam");
            };

            static Exception _exception;
        }

        public class When_calling__NotNullAndHasItems__with_a_collection_containing_items : WithSubject<CheckArgument>
        {
            Establish context = () => _collection = new[] {"TestItem1", "TestItem2"};

            Because of = () => _result = CheckArgument.NotNullAndHasItems(_collection, "testParam");

            It should_return_collection = () =>
            {
                _result.ShouldNotBeNull();
                _result.ShouldContain(_collection);
            };

            static IEnumerable<string> _result;
            static IEnumerable<string> _collection;
        }

        public class When_calling__NotEmpty__with_a_null_string : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotEmpty(null, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Parameter 'testParam' is null, empty or contains only whitespace.");
            };

            static Exception _exception;
        }

        public class When_calling__NotEmpty__with_an_empty_string : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotEmpty(String.Empty, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Parameter 'testParam' is null, empty or contains only whitespace.");
            };

            static Exception _exception;
        }

        public class When_calling__NotEmpty__with_a_string_containing_only_whitespace : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotEmpty("    ", "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Parameter 'testParam' is null, empty or contains only whitespace.");
            };

            static Exception _exception;
        }

        public class When_calling__NotEmpty__with_a_non_null_parameter : WithSubject<CheckArgument>
        {
            Because of = () => _result = CheckArgument.NotEmpty("BLAH", "testParam");

            It should_return_parameter = () => _result.ShouldEqual("BLAH");

            static string _result;
        }


        public class When_calling__NotZero__with_a_parameter_of_zero : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotZero(0, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Parameter 'testParam' cannot be zero.");
            };

            static Exception _exception;
        }

        public class When_calling__NotZero__with_a_non_zero_parameter : WithSubject<CheckArgument>
        {
            Because of = () => _result = CheckArgument.NotZero(Int32.MaxValue, "testParam");

            It should_return_parameter = () => _result.ShouldEqual(Int32.MaxValue);

            static int _result;
        }
    }
}