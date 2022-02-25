import Foundation
import UIKit
@objc public class SwiftForUnity: UIViewController {
      @objc static let shared = SwiftForUnity()
      @objc func SayHiToUnity() -> String{
            return "Hi, I'm Swift"
      }
}
