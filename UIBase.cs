
/*
	脚本名称 : UIBase.cs

	创建人 : #AuthorName#

	创建时间 : #CreateTime#

*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//强制依赖组件
[RequireComponent(typeof(CanvasGroup))]
public class UIBase : MonoBehaviour {

	public string UIName="";
	public int UILayer=0;
	protected CanvasGroup canvasGroup;
	protected virtual void Awake(){canvasGroup = GetComponent<CanvasGroup> ();}

	/// <summary>
	/// 进入
	/// </summary>
	public virtual void DoOnEntering(){}

	/// <summary>
	/// 锁定
	/// </summary>
	public virtual void DoOnPausing(){}

	/// <summary>
	/// 解锁
	/// </summary>
	public virtual void DoOnResuming(){}

	/// <summary>
	/// 退出
	/// </summary>
	public virtual void DoOnExiting(){}

}
