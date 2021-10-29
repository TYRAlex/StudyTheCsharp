/*
 * 单例模式中的延迟加载（Lazy 关键字）
 * 通常将对象的初始化延迟到需要时，因此，延迟加载的主要目标是按需加载对象，或者可以根据需要说出对象
 */

using System;

namespace SingletonPattern
{
    /// <summary>
    /// 延迟加载单例模式
    /// </summary>
    public class SingletonLazyMode
    {
        private static readonly Lazy<SingletonLazyMode> InstanceLock =
            new Lazy<SingletonLazyMode>(() => new SingletonLazyMode());

        public static SingletonLazyMode GetInstance
        {
            get
            {
                return InstanceLock.Value;
            }
        }
    }
}