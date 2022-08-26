﻿namespace RxBim.Tools.Autocad
{
    using System;

    /// <summary>
    /// Extensions for <see cref="ITransactionService"/> for <see cref="DocumentContext"/>.
    /// </summary>
    public static class DocumentTransactionServiceExtensions
    {
        /// <summary>
        /// <inheritdoc cref="ITransactionService.RunInTransaction{T}(Action{T}, string, T)" path="/summary" />
        /// </summary>
        /// <param name="transactionService"><see cref="ITransactionService"/> object.</param>
        /// <param name="action"><inheritdoc cref="ITransactionService.RunInTransaction{T}(Action{T}, string, T)" path="/param[@name='action']" /></param>
        /// <param name="context"><inheritdoc cref="ITransactionService.RunInTransaction{T}(Action{T}, string, T)" path="/param[@name='context']" /></param>
        public static void RunInDocumentTransaction(
            this ITransactionService transactionService,
            Action action,
            DocumentContext? context = null)
        {
            transactionService.RunInTransaction(_ => action(), null, context);
        }

        /// <summary>
        /// <inheritdoc cref="ITransactionService.RunInTransaction{T}(Action{T, ITransaction}, string, T)" path="/summary" />
        /// </summary>
        /// <param name="transactionService"><see cref="ITransactionService"/> object.</param>
        /// <param name="action"><inheritdoc cref="ITransactionService.RunInTransaction{T}(Action{T, ITransaction}, string, T)" path="/param[@name='action']" /></param>
        /// <param name="context"><inheritdoc cref="ITransactionService.RunInTransaction{T}(Action{T, ITransaction}, string, T)" path="/param[@name='context']" /></param>
        public static void RunInDocumentTransaction(
            this ITransactionService transactionService,
            Action<ITransaction> action,
            DocumentContext? context = null)
        {
            transactionService.RunInTransaction((_, x) => action(x), null, context);
        }

        /// <summary>
        /// <inheritdoc cref="ITransactionService.RunInTransaction{T1,T2}(Func{T1,T2}, string, T1)" path="/summary" />
        /// </summary>
        /// <param name="transactionService"><see cref="ITransactionService"/> object.</param>
        /// <param name="func"><inheritdoc cref="ITransactionService.RunInTransaction{T1,T2}(Func{T1,T2}, string, T1)" path="/param[@name='func']" /></param>
        /// <param name="context"><inheritdoc cref="ITransactionService.RunInTransaction{T1,T2}(Func{T1,T2}, string, T1)" path="/param[@name='context']" /></param>
        /// <typeparam name="T"><inheritdoc cref="ITransactionService.RunInTransaction{T1,T2}(Func{T1,T2}, string, T1)" path="/typeparam[@name='TRes']" /></typeparam>
        public static T RunInDocumentTransaction<T>(
            this ITransactionService transactionService,
            Func<T> func,
            DocumentContext? context = null)
        {
            return transactionService.RunInTransaction(_ => func(), null, context);
        }

        /// <summary>
        /// <inheritdoc cref="ITransactionService.RunInTransaction{T1,T2}(Func{T1,ITransaction,T2}, string, T1)" path="/summary" />
        /// </summary>
        /// <param name="transactionService"><see cref="ITransactionService"/> object.</param>
        /// <param name="func"><inheritdoc cref="ITransactionService.RunInTransaction{T1,T2}(Func{T1,ITransaction,T2}, string, T1)" path="/param[@name='func']" /></param>
        /// <param name="context"><inheritdoc cref="ITransactionService.RunInTransaction{T1,T2}(Func{T1,ITransaction,T2}, string, T1)" path="/param[@name='context']" /></param>
        /// <typeparam name="T"><inheritdoc cref="ITransactionService.RunInTransaction{T1,T2}(Func{T1,ITransaction,T2}, string, T1)" path="/typeparam[@name='TRes']" /></typeparam>
        public static T RunInDocumentTransaction<T>(
            this ITransactionService transactionService,
            Func<ITransaction, T> func,
            DocumentContext? context = null)
        {
            return transactionService.RunInTransaction((_, x) => func(x), null, context);
        }

        /// <summary>
        /// <inheritdoc cref="ITransactionService.RunInTransactionGroup{T}(Action{T}, string, T)" path="/summary" />
        /// </summary>
        /// <param name="transactionService"><see cref="ITransactionService"/> object.</param>
        /// <param name="action"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T}(Action{T}, string, T)" path="/param[@name='action']" /></param>
        /// <param name="context"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T}(Action{T}, string, T)" path="/param[@name='context']" /></param>
        public static void RunInDocumentTransactionGroup(
            this ITransactionService transactionService,
            Action action,
            DocumentContext? context = null)
        {
            transactionService.RunInTransactionGroup(_ => action(), string.Empty, context);
        }

        /// <summary>
        /// <inheritdoc cref="ITransactionService.RunInTransactionGroup{T}(Action{T,ITransactionGroup}, string, T)"  path="/summary" />
        /// </summary>
        /// <param name="transactionService"><see cref="ITransactionService"/> object.</param>
        /// <param name="action"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T}(Action{T,ITransactionGroup}, string, T)" path="/param[@name='action']" /></param>
        /// <param name="context"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T}(Action{T,ITransactionGroup}, string, T)" path="/param[@name='context']" /></param>
        public static void RunInDocumentTransactionGroup(
            this ITransactionService transactionService,
            Action<ITransactionGroup> action,
            DocumentContext? context = null)
        {
            transactionService.RunInTransactionGroup((_, x) => action(x), string.Empty, context);
        }

        /// <summary>
        /// <inheritdoc cref="ITransactionService.RunInTransactionGroup{T1,T2}(Func{T1,T2}, string, T1)" path="/summary" />
        /// </summary>
        /// <param name="transactionService"><see cref="ITransactionService"/> object.</param>
        /// <param name="func"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T1,T2}(Func{T1,T2}, string, T1)" path="/param[@name='func']" /></param>
        /// <param name="context"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T1,T2}(Func{T1,T2}, string, T1)" path="/param[@name='context']" /></param>
        /// <typeparam name="T"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T1,T2}(Func{T1,T2}, string, T1)" path="/typeparam[@name='TRes']" /></typeparam>
        public static T RunInDocumentTransactionGroup<T>(
            this ITransactionService transactionService,
            Func<T> func,
            DocumentContext? context = null)
        {
            return transactionService.RunInTransactionGroup(_ => func(), string.Empty, context);
        }

        /// <summary>
        /// <inheritdoc cref="ITransactionService.RunInTransactionGroup{T1,T2}(Func{T1,ITransactionGroup,T2}, string, T1)" path="/summary"/>
        /// </summary>
        /// <param name="transactionService"><see cref="ITransactionService"/> object.</param>
        /// <param name="func"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T1,T2}(Func{T1,ITransactionGroup,T2}, string, T1)" path="/param[@name='func']" /></param>
        /// <param name="context"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T1,T2}(Func{T1,ITransactionGroup,T2}, string, T1)" path="/param[@name='context']" /></param>
        /// <typeparam name="T"><inheritdoc cref="ITransactionService.RunInTransactionGroup{T1,T2}(Func{T1,ITransactionGroup,T2}, string, T1)" path="/typeparam[@name='TRes']" /></typeparam>
        public static T RunInDocumentTransactionGroup<T>(
            this ITransactionService transactionService,
            Func<ITransactionGroup, T> func,
            DocumentContext? context = null)
        {
            return transactionService.RunInTransactionGroup((_, x) => func(x), string.Empty, context);
        }
    }
}