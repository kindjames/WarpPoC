using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using Machine.Specifications;

namespace WarpTesting.Util
{
    public static class ShouldExtensionMethods
    {
        public static void ShouldHaveAttribute<TController, TAction, TAttribute>(this TController obj, Expression<Func<TController, TAction>> exp)
            where TController : Controller
        {
            var memberExpression = (MethodCallExpression)exp.Body;
            var attributeType = typeof(TAttribute);

            if (!memberExpression.Method.GetCustomAttributes(attributeType, false).Any())
            {
                throw new SpecificationException(attributeType.Name + " not found on " + memberExpression.Method.Name);
            }
        }

        public static void ShouldAcceptHttpPostRequests<TController, TAction>(this TController obj, Expression<Func<TController, TAction>> exp)
            where TController : Controller
        {
            ShouldHaveAttribute<TController, TAction, HttpPostAttribute>(obj, exp);
        }

        public static void ShouldAcceptHttpGetRequests<TController, TAction>(this TController obj, Expression<Func<TController, TAction>> exp)
            where TController : Controller
        {
            ShouldHaveAttribute<TController, TAction, HttpGetAttribute>(obj, exp);
        }

        public static void ShouldAllowAnonymousRequests<TController, TAction>(this TController obj, Expression<Func<TController, TAction>> exp)
            where TController : Controller
        {
            ShouldHaveAttribute<TController, TAction, AllowAnonymousAttribute>(obj, exp);
        }
    }
}