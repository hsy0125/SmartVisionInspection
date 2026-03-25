# 🚗 SmartVisionInspection

산업용 비전 검사 시스템을 목표로 개발한 WinForms 기반 검사 프로그램입니다.  
기존의 Blob / Match 기반 검사 방식에 AI 기반 Detection/Segmentation을 확장 가능하도록 설계한 프로젝트입니다.

---

## 📖 프로젝트 소개

SmartVisionInspection은 이미지 데이터를 기반으로 불량 여부를 검사하고,  
검사 결과를 시각적으로 제공하는 검사 시스템입니다.

단순한 기능 구현이 아닌,  
👉 **검사 알고리즘 + UI + 실행 구조를 통합한 검사 플랫폼 구조 설계**를 목표로 개발되었습니다.

---

## 🎯 개발 목표

- Blob / Match 기반 검사 시스템 구현
- 검사 결과 시각화 및 UI 제공
- 검사 실행 구조 모듈화 (확장성 확보)
- AI 기반 검사 (Detection / Segmentation) 연동 가능한 구조 설계

---

## 🧩 주요 기능

### 1. 이미지 검사 기능
- Blob 기반 영역 검출
- Match 기반 패턴 매칭
- ROI 설정 및 검사 수행

### 2. 검사 결과 시각화
- 이미지 위 검사 결과 표시
- Bounding Box 및 영역 표시
- 검사 상태 (OK / NG) 표현

### 3. 로그 시스템
- log4net 기반 로그 출력
- LogForm UI를 통한 실시간 로그 확인
- 검사 흐름 및 오류 추적 가능

### 4. 검사 실행 구조
- InspWorker 기반 검사 실행 단위 관리
- InspectBoard를 통한 검사 작업 관리
- UI와 검사 로직 분리

---

## 🏗️ 시스템 구조

### 🔹 전체 흐름
Camera → InspectBoard → InspWorker → Algorithm → Result + Log


---

### 🔹 핵심 구조

| 구성 요소 | 설명 |
|----------|------|
| Camera | 이미지 입력 (WebCam / HikRobotCam) |
| InspectBoard | 검사 작업 관리 |
| InspWorker | 검사 실행 단위 |
| Algorithm | Blob / Match / AI 검사 |
| Result | 검사 결과 데이터 |
| UI | 결과 및 상태 표시 |
| Logger | 검사 로그 관리 |

---

### 🔹 프로젝트 구조
SmartVisionInspection
├── Algorithm # 검사 알고리즘 (Blob, Match 등)
├── Core # 검사 흐름 및 공통 구조
├── Grab # 카메라 처리 (WebCam, HikRobot)
├── Inspect # 검사 실행 구조 (InspWorker, InspectBoard)
├── Property # 검사 파라미터 설정
├── UIControl # 커스텀 UI 컨트롤
├── Teach # 검사 모델 관리
├── Setting # 설정 관리
├── Util # 로그 및 유틸

---
### 동작 결과
## RunForm
<img width="2559" height="1523" alt="image" src="https://github.com/user-attachments/assets/cd41ae1a-d20d-4bd6-9d9b-95c978c3ba68" />
## 티칭창
<img width="2558" height="1519" alt="image" src="https://github.com/user-attachments/assets/8cadad68-293e-4d86-a67e-0a1de694f28a" />
## InspMatch
<img width="625" height="1009" alt="image" src="https://github.com/user-attachments/assets/edcc5ced-0bb8-43a4-b714-8bb3e0ca5113" />

---

## 🔧 기술 스택

- Language: C#
- Framework: .NET Framework (WinForms)
- Image Processing: OpenCV (OpenCvSharp)
- Logging: log4net
- UI: Windows Forms + Custom Control

---

## 💡 설계 포인트 (핵심)

### 1. 검사 실행 구조 분리
- InspStage 중심 구조 → InspWorker 기반 구조로 리팩토링
- 검사 단위를 클래스로 분리하여 확장성 확보

### 2. UI와 로직 분리
- 검사 실행 로직과 UI를 분리하여 유지보수성 향상

### 3. 확장 가능한 구조
- AI Detection / Segmentation 모듈 추가 가능
- 향후 다양한 검사 알고리즘 확장 가능

---

## 🚀 향후 개선 방향

- AI Detection / Segmentation 연동
- 검사 결과 DB 저장
- 실시간 스트리밍 처리 개선
- 성능 최적화 (멀티 스레딩)

---

## 📌 개발자 관점 성과

- 단순 기능 구현이 아닌 **검사 시스템 아키텍처 설계 경험**
- UI + 알고리즘 + 실행 구조 통합 경험
- 유지보수성과 확장성을 고려한 구조 설계

---

## 🙋‍♀️ Author

허소영  
Mobile Convergence Engineering  
AI / Computer Vision Developer
